
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Report Type
    /// </summary>
    public enum ReportTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Analytics,
        /// <summary>
        /// 
        /// </summary>
        Tools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportTypeEnum value)
        {
            return value switch
            {
                ReportTypeEnum.Analytics => "analytics",
                ReportTypeEnum.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "analytics" => ReportTypeEnum.Analytics,
                "tools" => ReportTypeEnum.Tools,
                _ => null,
            };
        }
    }
}