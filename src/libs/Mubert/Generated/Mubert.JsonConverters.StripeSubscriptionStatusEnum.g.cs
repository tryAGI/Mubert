#nullable enable

namespace Mubert.JsonConverters
{
    /// <inheritdoc />
    public sealed class StripeSubscriptionStatusEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mubert.StripeSubscriptionStatusEnum>
    {
        /// <inheritdoc />
        public override global::Mubert.StripeSubscriptionStatusEnum Read(
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
                        return global::Mubert.StripeSubscriptionStatusEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mubert.StripeSubscriptionStatusEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mubert.StripeSubscriptionStatusEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mubert.StripeSubscriptionStatusEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mubert.StripeSubscriptionStatusEnumExtensions.ToValueString(value));
        }
    }
}
