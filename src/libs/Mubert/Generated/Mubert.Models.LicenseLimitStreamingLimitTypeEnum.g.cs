
#nullable enable

namespace Mubert
{
    /// <summary>
    /// License Limit Tracks Limit Types
    /// </summary>
    public enum LicenseLimitStreamingLimitTypeEnum
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
    public static class LicenseLimitStreamingLimitTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitStreamingLimitTypeEnum value)
        {
            return value switch
            {
                LicenseLimitStreamingLimitTypeEnum.Daily => "daily",
                LicenseLimitStreamingLimitTypeEnum.Monthly => "monthly",
                LicenseLimitStreamingLimitTypeEnum.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitStreamingLimitTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "daily" => LicenseLimitStreamingLimitTypeEnum.Daily,
                "monthly" => LicenseLimitStreamingLimitTypeEnum.Monthly,
                "total" => LicenseLimitStreamingLimitTypeEnum.Total,
                _ => null,
            };
        }
    }
}