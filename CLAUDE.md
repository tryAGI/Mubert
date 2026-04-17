# CLAUDE.md -- Mubert SDK

## Overview

Auto-generated C# SDK for [Mubert](https://mubert.com/) -- an adaptive AI music generation
platform with text-to-music, image-to-music, playlist-channel generation, track editing
(stem/instrument replace and delete), live HTTP/WebRTC streaming, and a curated 12k+ track
music library.

Generated from Mubert's public OpenAPI 3.0 spec at
`https://music-api.mubert.com/swagger-doc/openapi-prod.json`. The spec is stored
unchanged in the repo root as `openapi.yaml`; all workarounds are applied by
`src/libs/Mubert/generate.sh` before handing the spec to AutoSDK.

## Build & Test

```bash
dotnet build Mubert.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Mubert uses **dual-header authentication**:
- Public customer endpoints: `customer-id` + `access-token`
- Service endpoints: `company-id` + `license-token`

```csharp
// Public (default)
using var client = new MubertClient(customerId, accessToken);

// Service (same client, explicit scope enum)
using var service = new MubertClient(companyId, licenseToken, MubertServiceScope.Service);
```

Because AutoSDK can only inject a single security scheme, we generate with
`--security-scheme Http:Header:Bearer` (for the constructor scaffolding), then the
custom constructors clear `Authorizations` and set both headers on
`HttpClient.DefaultRequestHeaders` so every sub-client (`Public`, `PublicService`,
`Service`) inherits them.

## Key Files

- `openapi.yaml` -- Downloaded Mubert OpenAPI 3.0 spec (stored unchanged at repo root).
- `src/libs/Mubert/generate.sh` -- Copies the spec, rewrites MD5 `operationId`s to readable
  `verbPath` names, strips per-operation `customer-id`/`access-token`/`company-id`/`license-token`
  header parameters (handled globally via `DefaultRequestHeaders`), then runs AutoSDK with
  `--security-scheme Http:Header:Bearer`.
- `src/libs/Mubert/Generated/` -- **Never edit** -- auto-generated code (~552 files).
- `src/libs/Mubert/MubertClient.Auth.cs` -- Dual-header constructors + `DefaultBaseUrlValue`
  (`https://music-api.mubert.com`) + `Initialized` partial to set `BaseAddress` (spec has no
  `servers[]` block).
- `src/libs/Mubert/Extensions/MubertClient.Tools.cs` -- MEAI `AIFunction` tool factory
  extensions.
- `src/tests/IntegrationTests/Tests.cs` -- Test helper; reads `MUBERT_CUSTOMER_ID` +
  `MUBERT_ACCESS_TOKEN` from env, skips via `AssertInconclusiveException` when missing.
- `src/tests/IntegrationTests/Examples/` -- Example tests (also feed the docs pipeline).

## API Base URL

`https://music-api.mubert.com`

The Mubert spec omits a `servers[]` entry, so the generated `DefaultBaseUrl` is empty;
`MubertClient.Auth.cs` wires the default in the `Initialized` partial.

## Spec Notes

- **Dual-header auth.** The spec declares `customer-id`/`access-token` (public) and
  `company-id`/`license-token` (service) as per-operation header parameters, without a
  `securitySchemes` block. AutoSDK can inject only a single auth scheme, so we handle the
  pair manually via `HttpClient.DefaultRequestHeaders`.
- **MD5 operationIds.** Every operation in the source spec uses an MD5 hash as its
  `operationId`, which would produce opaque method names. `generate.sh` rewrites them to
  readable `verbPath` slugs (e.g. `postPublicTracks`, `getPublicStreamingGetLink`).
- **No `servers[]`.** The spec omits a server URL so we set
  `https://music-api.mubert.com` as the default base URI.

## Sub-clients

```csharp
var client = new MubertClient(customerId, accessToken);

// Track generation + management
client.Public.PostPublicTracksAsync(...)             // Create (prompt, playlist, or image)
client.Public.GetPublicTracksAsync(...)              // List tracks
client.Public.GetPublicTracksByTrackAsync(id)        // Get track status / download urls
client.Public.PostPublicTracksByTrackEditAsync(...)  // Edit / replace stems or instruments
client.Public.PostPublicTracksByTrackSimilarAsync(...)// Generate similar track
client.Public.PostPublicTracksStoredAsync(...)       // Store track
client.Public.PostPublicTracksRecordAsync(...)       // Record stream segment
client.Public.GetPublicTracksSessionBySessionIdAsync // Get by session id

// Playlists / catalog
client.Public.GetPublicPlaylistsAsync()              // Channels (category/group/channel)
client.Public.GetPublicMusicLibraryParamsAsync(...)  // Filter values for the library
client.Public.GetPublicMusicLibraryTracksAsync(...)  // Browse 12k+ curated tracks

// Streaming
client.Public.GetPublicStreamingGetLinkAsync(...)    // Live stream URL (HTTP/WebRTC)
client.Public.PostPublicStreamingSetIntensityAsync() // Adjust intensity mid-stream
client.Public.PostPublicStreamingSetLoopStateAsync() // Set loop state
client.Public.PostPublicStreamingRestartAsync()      // Restart stream

// Subscriptions + pricing
client.Public.GetPublicPricesAsync()
client.Public.PostPublicSubscriptionsBuyAsync(...)
client.Public.PostPublicSubscriptionsCancelAsync(...)

// Service-scope (company-id + license-token auth)
client.Service.*            // Stripe billing portal, service subscriptions
client.PublicService.*      // Customer + license CRUD
```

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsTextToMusicTool()` | Generate a track from a natural-language prompt. |
| `AsGenerateTrackTool()` | Generate a track from a playlist index (category.group.channel). |
| `AsGetTrackStatusTool()` | Fetch the current status / download URLs of a generated track. |
| `AsListPlaylistsTool()` | List all available Mubert channels (category/group/channel). |
| `AsStreamMusicTool()` | Get a live HTTP/WebRTC streaming URL for a channel. |
