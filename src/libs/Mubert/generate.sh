dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
cp ../../../openapi.yaml openapi.yaml

# The Mubert spec uses MD5-hash operationIds and dual-header auth
# (customer-id + access-token). AutoSDK can only inject a single security
# scheme, so we generate with a Bearer scheme and override with a custom
# dual-header constructor that uses HttpClient.DefaultRequestHeaders.
#
# Preprocessing:
#   1. Replace MD5 operationIds with readable camelCase names derived from
#      the path + HTTP method.
#   2. Strip the per-operation customer-id/access-token/company-id/license-token
#      header parameters (auth is handled globally on DefaultRequestHeaders).
#   3. Rename the referenced parameter components so the cleanup doesn't leave
#      dangling $refs.
python3 << 'PYEOF'
import re
import yaml

with open('openapi.yaml') as f:
    spec = yaml.safe_load(f)

def slug(path: str, method: str) -> str:
    # Strip the common /api/v3/ prefix
    p = re.sub(r'^/api/v3/', '', path)
    # Normalise path params: {track} -> ByTrack
    parts = []
    for raw in p.split('/'):
        if not raw:
            continue
        if raw.startswith('{') and raw.endswith('}'):
            inner = raw[1:-1]
            parts.append('By' + ''.join(w.capitalize() for w in re.split(r'[-_]', inner)))
        else:
            parts.append(''.join(w.capitalize() for w in re.split(r'[-_]', raw)))
    name = method.lower() + ''.join(parts)
    return name

AUTH_HEADERS = {'customer-id', 'access-token', 'company-id', 'license-token'}

for path, item in (spec.get('paths') or {}).items():
    if not isinstance(item, dict):
        continue
    for method, op in list(item.items()):
        if method not in ('get', 'post', 'put', 'patch', 'delete', 'options', 'head'):
            continue
        if not isinstance(op, dict):
            continue
        # Rewrite MD5 operationIds
        oid = op.get('operationId', '')
        if re.fullmatch(r'[a-f0-9]{32}', oid):
            op['operationId'] = slug(path, method)
        # Strip auth header parameters (handled via DefaultRequestHeaders)
        params = op.get('parameters') or []
        filtered = []
        for p in params:
            if isinstance(p, dict):
                ref = p.get('$ref', '')
                if ref.startswith('#/components/parameters/'):
                    pname = ref.rsplit('/', 1)[-1]
                    if pname in AUTH_HEADERS:
                        continue
                if p.get('in') == 'header' and p.get('name') in AUTH_HEADERS:
                    continue
            filtered.append(p)
        if filtered:
            op['parameters'] = filtered
        elif 'parameters' in op:
            del op['parameters']

# Drop the auth parameter components themselves so the spec stays clean.
comp_params = spec.get('components', {}).get('parameters', {})
for name in list(comp_params.keys()):
    if name in AUTH_HEADERS:
        del comp_params[name]

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)
PYEOF

autosdk generate openapi.yaml \
  --namespace Mubert \
  --clientClassName MubertClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
