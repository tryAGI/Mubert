
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Order Directions
    /// </summary>
    public enum OrderDirectionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderDirectionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderDirectionEnum value)
        {
            return value switch
            {
                OrderDirectionEnum.Asc => "asc",
                OrderDirectionEnum.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderDirectionEnum? ToEnum(string value)
        {
            return value switch
            {
                "asc" => OrderDirectionEnum.Asc,
                "desc" => OrderDirectionEnum.Desc,
                _ => null,
            };
        }
    }
}