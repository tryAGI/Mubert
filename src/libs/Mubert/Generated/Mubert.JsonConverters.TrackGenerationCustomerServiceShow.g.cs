#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class TrackGenerationCustomerServiceShowJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.TrackGenerationCustomerServiceShow>
    {
        /// <inheritdoc />
        public override global::Mubert.TrackGenerationCustomerServiceShow Read(
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
            if (__jsonProps.Contains("bitrate")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("expired_at")) __score0++;
            if (__jsonProps.Contains("format")) __score0++;
            if (__jsonProps.Contains("generated_at")) __score0++;
            if (__jsonProps.Contains("session_id")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mubert.TrackGenerationServiceResource? resource = default;
            global::Mubert.TrackGenerationCustomerServiceShowVariant2? trackGenerationCustomerServiceShowVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationServiceResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationServiceResource).Name}");
                        resource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationCustomerServiceShowVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2).Name}");
                        trackGenerationCustomerServiceShowVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (resource == null && trackGenerationCustomerServiceShowVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationServiceResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationServiceResource).Name}");
                    resource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationCustomerServiceShowVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2).Name}");
                    trackGenerationCustomerServiceShowVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mubert.TrackGenerationCustomerServiceShow(
                resource,

                trackGenerationCustomerServiceShowVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.TrackGenerationCustomerServiceShow value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationServiceResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationServiceResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Resource!, typeInfo);
            }
            else if (value.IsTrackGenerationCustomerServiceShowVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackGenerationCustomerServiceShowVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrackGenerationCustomerServiceShowVariant2!, typeInfo);
            }
        }
    }
}