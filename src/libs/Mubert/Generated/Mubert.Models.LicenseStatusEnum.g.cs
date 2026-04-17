
#nullable enable

namespace Mubert
{
    /// <summary>
    /// License Statuses
    /// </summary>
    public enum LicenseStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LicenseStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseStatusEnum value)
        {
            return value switch
            {
                LicenseStatusEnum.Active => "active",
                LicenseStatusEnum.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "active" => LicenseStatusEnum.Active,
                "inactive" => LicenseStatusEnum.Inactive,
                _ => null,
            };
        }
    }
}