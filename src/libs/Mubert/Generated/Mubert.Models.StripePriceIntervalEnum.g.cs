
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Price Intervals
    /// </summary>
    public enum StripePriceIntervalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripePriceIntervalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripePriceIntervalEnum value)
        {
            return value switch
            {
                StripePriceIntervalEnum.Day => "day",
                StripePriceIntervalEnum.Month => "month",
                StripePriceIntervalEnum.Week => "week",
                StripePriceIntervalEnum.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripePriceIntervalEnum? ToEnum(string value)
        {
            return value switch
            {
                "day" => StripePriceIntervalEnum.Day,
                "month" => StripePriceIntervalEnum.Month,
                "week" => StripePriceIntervalEnum.Week,
                "year" => StripePriceIntervalEnum.Year,
                _ => null,
            };
        }
    }
}