
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public enum StripePricePublicResourceInterval
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
    public static class StripePricePublicResourceIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripePricePublicResourceInterval value)
        {
            return value switch
            {
                StripePricePublicResourceInterval.Day => "day",
                StripePricePublicResourceInterval.Month => "month",
                StripePricePublicResourceInterval.Week => "week",
                StripePricePublicResourceInterval.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripePricePublicResourceInterval? ToEnum(string value)
        {
            return value switch
            {
                "day" => StripePricePublicResourceInterval.Day,
                "month" => StripePricePublicResourceInterval.Month,
                "week" => StripePricePublicResourceInterval.Week,
                "year" => StripePricePublicResourceInterval.Year,
                _ => null,
            };
        }
    }
}