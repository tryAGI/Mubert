#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public class PlaylistCustomerServiceIndexResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.PlaylistCustomerServiceIndexResource>
    {
        /// <inheritdoc />
        public override global::Mubert.PlaylistCustomerServiceIndexResource Read(
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
            if (__jsonProps.Contains("category")) __score0++;
            if (__jsonProps.Contains("channel")) __score0++;
            if (__jsonProps.Contains("group")) __score0++;
            if (__jsonProps.Contains("playlist_index")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Mubert.PlaylistServiceResource? playlistServiceResource = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.PlaylistServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.PlaylistServiceResource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.PlaylistServiceResource).Name}");
                        playlistServiceResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (playlistServiceResource == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.PlaylistServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.PlaylistServiceResource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.PlaylistServiceResource).Name}");
                    playlistServiceResource = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mubert.PlaylistCustomerServiceIndexResource(
                playlistServiceResource
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.PlaylistCustomerServiceIndexResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlaylistServiceResource)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mubert.PlaylistServiceResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mubert.PlaylistServiceResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mubert.PlaylistServiceResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlaylistServiceResource!, typeInfo);
            }
        }
    }
}