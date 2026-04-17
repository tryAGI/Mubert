
#nullable enable

namespace Mubert
{
    /// <summary>
    /// License Types
    /// </summary>
    public enum LicenseTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        Trial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LicenseTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseTypeEnum value)
        {
            return value switch
            {
                LicenseTypeEnum.Paid => "paid",
                LicenseTypeEnum.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "paid" => LicenseTypeEnum.Paid,
                "trial" => LicenseTypeEnum.Trial,
                _ => null,
            };
        }
    }
}