
#nullable enable

namespace Mubert
{
    /// <summary>
    /// The time-based limit type that was exceeded (e.g., daily, monthly, total).<br/>
    /// Example: monthly
    /// </summary>
    public enum LicenseLimitTracksCountExceptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Total,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LicenseLimitTracksCountExceptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitTracksCountExceptionType value)
        {
            return value switch
            {
                LicenseLimitTracksCountExceptionType.Daily => "daily",
                LicenseLimitTracksCountExceptionType.Monthly => "monthly",
                LicenseLimitTracksCountExceptionType.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitTracksCountExceptionType? ToEnum(string value)
        {
            return value switch
            {
                "daily" => LicenseLimitTracksCountExceptionType.Daily,
                "monthly" => LicenseLimitTracksCountExceptionType.Monthly,
                "total" => LicenseLimitTracksCountExceptionType.Total,
                _ => null,
            };
        }
    }
}