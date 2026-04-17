
#nullable enable

namespace Mubert
{
    /// <summary>
    /// The time-based duration limit type that was exceeded (e.g., daily, monthly, total).<br/>
    /// Example: monthly
    /// </summary>
    public enum LicenseLimitStreamingDurationExceptionType
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
    public static class LicenseLimitStreamingDurationExceptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitStreamingDurationExceptionType value)
        {
            return value switch
            {
                LicenseLimitStreamingDurationExceptionType.Daily => "daily",
                LicenseLimitStreamingDurationExceptionType.Monthly => "monthly",
                LicenseLimitStreamingDurationExceptionType.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitStreamingDurationExceptionType? ToEnum(string value)
        {
            return value switch
            {
                "daily" => LicenseLimitStreamingDurationExceptionType.Daily,
                "monthly" => LicenseLimitStreamingDurationExceptionType.Monthly,
                "total" => LicenseLimitStreamingDurationExceptionType.Total,
                _ => null,
            };
        }
    }
}