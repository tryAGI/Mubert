#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class TrackShowPublicResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.TrackShowPublicResource>
    {
        /// <inheritdoc />
        public override global::Mubert.TrackShowPublicResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Mubert.TrackPublicResource? trackPublicResource = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackPublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackPublicResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackPublicResource).Name}");
                trackPublicResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Mubert.TrackShowPublicResourceVariant2? trackShowPublicResourceVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackShowPublicResourceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackShowPublicResourceVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackShowPublicResourceVariant2).Name}");
                trackShowPublicResourceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Mubert.TrackShowPublicResource(
                trackPublicResource,

                trackShowPublicResourceVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.TrackShowPublicResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsTrackPublicResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackPublicResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackPublicResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackPublicResource).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TrackPublicResource!, typeInfo);
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
            if (value.IsTrackShowPublicResourceVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.TrackShowPublicResourceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.TrackShowPublicResourceVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.TrackShowPublicResourceVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TrackShowPublicResourceVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
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