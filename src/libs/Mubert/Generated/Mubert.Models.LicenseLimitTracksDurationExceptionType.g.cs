
#nullable enable

namespace Mubert
{
    /// <summary>
    /// The time-based duration limit type that was exceeded (e.g., daily, monthly, total).<br/>
    /// Example: monthly
    /// </summary>
    public enum LicenseLimitTracksDurationExceptionType
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
    public static class LicenseLimitTracksDurationExceptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitTracksDurationExceptionType value)
        {
            return value switch
            {
                LicenseLimitTracksDurationExceptionType.Daily => "daily",
                LicenseLimitTracksDurationExceptionType.Monthly => "monthly",
                LicenseLimitTracksDurationExceptionType.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitTracksDurationExceptionType? ToEnum(string value)
        {
            return value switch
            {
                "daily" => LicenseLimitTracksDurationExceptionType.Daily,
                "monthly" => LicenseLimitTracksDurationExceptionType.Monthly,
                "total" => LicenseLimitTracksDurationExceptionType.Total,
                _ => null,
            };
        }
    }
}