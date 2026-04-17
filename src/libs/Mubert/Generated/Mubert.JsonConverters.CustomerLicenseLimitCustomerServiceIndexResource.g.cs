#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class CustomerLicenseLimitCustomerServiceIndexResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.CustomerLicenseLimitCustomerServiceIndexResource>
    {
        /// <inheritdoc />
        public override global::Mubert.CustomerLicenseLimitCustomerServiceIndexResource Read(
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
            if (__jsonProps.Contains("customer_id")) __score0++;
            if (__jsonProps.Contains("daily_reset_at")) __score0++;
            if (__jsonProps.Contains("daily_streaming_duration")) __score0++;
            if (__jsonProps.Contains("daily_streaming_duration_limit")) __score0++;
            if (__jsonProps.Contains("daily_tracks_count")) __score0++;
            if (__jsonProps.Contains("daily_tracks_count_limit")) __score0++;
            if (__jsonProps.Contains("daily_tracks_duration")) __score0++;
            if (__jsonProps.Contains("daily_tracks_duration_limit")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("license_id")) __score0++;
            if (__jsonProps.Contains("max_concurrent_track_generations")) __score0++;
            if (__jsonProps.Contains("monthly_reset_at")) __score0++;
            if (__jsonProps.Contains("monthly_streaming_duration")) __score0++;
            if (__jsonProps.Contains("monthly_streaming_duration_limit")) __score0++;
            if (__jsonProps.Contains("monthly_tracks_count")) __score0++;
            if (__jsonProps.Contains("monthly_tracks_count_limit")) __score0++;
            if (__jsonProps.Contains("monthly_tracks_duration")) __score0++;
            if (__jsonProps.Contains("monthly_tracks_duration_limit")) __score0++;
            if (__jsonProps.Contains("total_streaming_duration")) __score0++;
            if (__jsonProps.Contains("total_streaming_duration_limit")) __score0++;
            if (__jsonProps.Contains("total_tracks_count")) __score0++;
            if (__jsonProps.Contains("total_tracks_count_limit")) __score0++;
            if (__jsonProps.Contains("total_tracks_duration")) __score0++;
            if (__jsonProps.Contains("total_tracks_duration_limit")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Mubert.CustomerLicenseLimitServiceResource? customerLicenseLimitServiceResource = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.CustomerLicenseLimitServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.CustomerLicenseLimitServiceResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.CustomerLicenseLimitServiceResource).Name}");
                        customerLicenseLimitServiceResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (customerLicenseLimitServiceResource == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.CustomerLicenseLimitServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.CustomerLicenseLimitServiceResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.CustomerLicenseLimitServiceResource).Name}");
                    customerLicenseLimitServiceResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mubert.CustomerLicenseLimitCustomerServiceIndexResource(
                customerLicenseLimitServiceResource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.CustomerLicenseLimitCustomerServiceIndexResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustomerLicenseLimitServiceResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.CustomerLicenseLimitServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.CustomerLicenseLimitServiceResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.CustomerLicenseLimitServiceResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomerLicenseLimitServiceResource!, typeInfo);
            }
        }
    }
}