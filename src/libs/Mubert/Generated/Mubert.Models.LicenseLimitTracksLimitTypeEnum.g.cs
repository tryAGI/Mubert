
#nullable enable

namespace Mubert
{
    /// <summary>
    /// License Limit Tracks Limit Types
    /// </summary>
    public enum LicenseLimitTracksLimitTypeEnum
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
    public static class LicenseLimitTracksLimitTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitTracksLimitTypeEnum value)
        {
            return value switch
            {
                LicenseLimitTracksLimitTypeEnum.Daily => "daily",
                LicenseLimitTracksLimitTypeEnum.Monthly => "monthly",
                LicenseLimitTracksLimitTypeEnum.Total => "total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitTracksLimitTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "daily" => LicenseLimitTracksLimitTypeEnum.Daily,
                "monthly" => LicenseLimitTracksLimitTypeEnum.Monthly,
                "total" => LicenseLimitTracksLimitTypeEnum.Total,
                _ => null,
            };
        }
    }
}