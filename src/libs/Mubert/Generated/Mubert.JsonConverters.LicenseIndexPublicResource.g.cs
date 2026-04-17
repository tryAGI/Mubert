#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class LicenseIndexPublicResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.LicenseIndexPublicResource>
    {
        /// <inheritdoc />
        public override global::Mubert.LicenseIndexPublicResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("allow_all_bitrates")) __score0++;
            if (__jsonProps.Contains("allow_all_features")) __score0++;
            if (__jsonProps.Contains("allow_all_formats")) __score0++;
            if (__jsonProps.Contains("allow_all_intensities")) __score0++;
            if (__jsonProps.Contains("allow_all_modes")) __score0++;
            if (__jsonProps.Contains("bitrates")) __score0++;
            if (__jsonProps.Contains("company_id")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("default_bitrate")) __score0++;
            if (__jsonProps.Contains("default_format")) __score0++;
            if (__jsonProps.Contains("default_intensity")) __score0++;
            if (__jsonProps.Contains("default_mode")) __score0++;
            if (__jsonProps.Contains("expired_at")) __score0++;
            if (__jsonProps.Contains("features")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("intensities")) __score0++;
            if (__jsonProps.Contains("license_limits")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("track_expiration_time")) __score0++;
            if (__jsonProps.Contains("track_formats")) __score0++;
            if (__jsonProps.Contains("track_modes")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("webhook_enabled")) __score0++;
            if (__jsonProps.Contains("webhook_url")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Mubert.LicensePublicResource? licensePublicResource = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.LicensePublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.LicensePublicResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.LicensePublicResource).Name}");
                        licensePublicResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (licensePublicResource == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.LicensePublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.LicensePublicResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.LicensePublicResource).Name}");
                    licensePublicResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mubert.LicenseIndexPublicResource(
                licensePublicResource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.LicenseIndexPublicResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLicensePublicResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.LicensePublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.LicensePublicResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.LicensePublicResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LicensePublicResource!, typeInfo);
            }
        }
    }
}