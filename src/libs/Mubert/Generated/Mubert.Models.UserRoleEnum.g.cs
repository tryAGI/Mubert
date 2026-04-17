
#nullable enable

namespace Mubert
{
    /// <summary>
    /// User Role Types
    /// </summary>
    public enum UserRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        SuperAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRoleEnum value)
        {
            return value switch
            {
                UserRoleEnum.Admin => "admin",
                UserRoleEnum.SuperAdmin => "super-admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserRoleEnum.Admin,
                "super-admin" => UserRoleEnum.SuperAdmin,
                _ => null,
            };
        }
    }
}