#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class TrackStoreIndexPublicResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.TrackStoreIndexPublicResource>
    {
        /// <inheritdoc />
        public override global::Mubert.TrackStoreIndexPublicResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Mubert.TrackStorePublicResource? trackStorePublicResource = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackStorePublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackStorePublicResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackStorePublicResource).Name}");
                trackStorePublicResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Mubert.TrackStoreIndexPublicResource(
                trackStorePublicResource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.TrackStoreIndexPublicResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsTrackStorePublicResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackStorePublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackStorePublicResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackStorePublicResource).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TrackStorePublicResource!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}