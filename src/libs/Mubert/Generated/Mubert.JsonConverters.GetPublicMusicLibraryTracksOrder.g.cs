#nullable enable

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPublicMusicLibraryTracksOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.GetPublicMusicLibraryTracksOrder>
    {
        /// <inheritdoc />
        public override global::Mubert.GetPublicMusicLibraryTracksOrder Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Mubert.GetPublicMusicLibraryTracksOrderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mubert.GetPublicMusicLibraryTracksOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mubert.GetPublicMusicLibraryTracksOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.GetPublicMusicLibraryTracksOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mubert.GetPublicMusicLibraryTracksOrderExtensions.ToValueString(value));
        }
    }
}
