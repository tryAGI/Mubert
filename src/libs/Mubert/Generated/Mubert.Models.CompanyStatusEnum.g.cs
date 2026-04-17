
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Company Statuses
    /// </summary>
    public enum CompanyStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Banned,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompanyStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompanyStatusEnum value)
        {
            return value switch
            {
                CompanyStatusEnum.Active => "active",
                CompanyStatusEnum.Banned => "banned",
                CompanyStatusEnum.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompanyStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "active" => CompanyStatusEnum.Active,
                "banned" => CompanyStatusEnum.Banned,
                "inactive" => CompanyStatusEnum.Inactive,
                _ => null,
            };
        }
    }
}