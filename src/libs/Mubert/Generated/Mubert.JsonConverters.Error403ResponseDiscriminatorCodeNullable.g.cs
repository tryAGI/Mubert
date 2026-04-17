#nullable enable

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public sealed class Error403ResponseDiscriminatorCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.Error403ResponseDiscriminatorCode?>
    {
        /// <inheritdoc />
        public override global::Mubert.Error403ResponseDiscriminatorCode? Read(
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
                        return global::Mubert.Error403ResponseDiscriminatorCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mubert.Error403ResponseDiscriminatorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mubert.Error403ResponseDiscriminatorCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.Error403ResponseDiscriminatorCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mubert.Error403ResponseDiscriminatorCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
