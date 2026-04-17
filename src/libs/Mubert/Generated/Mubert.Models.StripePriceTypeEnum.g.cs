
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Price Types
    /// </summary>
    public enum StripePriceTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        OneTime,
        /// <summary>
        /// 
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripePriceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripePriceTypeEnum value)
        {
            return value switch
            {
                StripePriceTypeEnum.OneTime => "one_time",
                StripePriceTypeEnum.Recurring => "recurring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripePriceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "one_time" => StripePriceTypeEnum.OneTime,
                "recurring" => StripePriceTypeEnum.Recurring,
                _ => null,
            };
        }
    }
}