#nullable enable

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public sealed class StripePriceIntervalEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.StripePriceIntervalEnum>
    {
        /// <inheritdoc />
        public override global::Mubert.StripePriceIntervalEnum Read(
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
                        return global::Mubert.StripePriceIntervalEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mubert.StripePriceIntervalEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mubert.StripePriceIntervalEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.StripePriceIntervalEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mubert.StripePriceIntervalEnumExtensions.ToValueString(value));
        }
    }
}
