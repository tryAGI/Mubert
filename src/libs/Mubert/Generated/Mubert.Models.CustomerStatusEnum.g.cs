
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Customer Statuses
    /// </summary>
    public enum CustomerStatusEnum
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
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerStatusEnum value)
        {
            return value switch
            {
                CustomerStatusEnum.Active => "active",
                CustomerStatusEnum.Banned => "banned",
                CustomerStatusEnum.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "active" => CustomerStatusEnum.Active,
                "banned" => CustomerStatusEnum.Banned,
                "init" => CustomerStatusEnum.Init,
                _ => null,
            };
        }
    }
}