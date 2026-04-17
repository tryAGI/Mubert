
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Example: asc
    /// </summary>
    public enum GetPublicMusicLibraryTracksOrder
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
    public static class GetPublicMusicLibraryTracksOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPublicMusicLibraryTracksOrder value)
        {
            return value switch
            {
                GetPublicMusicLibraryTracksOrder.Asc => "asc",
                GetPublicMusicLibraryTracksOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPublicMusicLibraryTracksOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetPublicMusicLibraryTracksOrder.Asc,
                "desc" => GetPublicMusicLibraryTracksOrder.Desc,
                _ => null,
            };
        }
    }
}