
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Example: asc
    /// </summary>
    public enum GetPublicTracksOrder
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
    public static class GetPublicTracksOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPublicTracksOrder value)
        {
            return value switch
            {
                GetPublicTracksOrder.Asc => "asc",
                GetPublicTracksOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPublicTracksOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetPublicTracksOrder.Asc,
                "desc" => GetPublicTracksOrder.Desc,
                _ => null,
            };
        }
    }
}