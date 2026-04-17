
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Features
    /// </summary>
    public enum FeatureEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Itm,
        /// <summary>
        /// 
        /// </summary>
        MusicLibrary,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
        /// <summary>
        /// 
        /// </summary>
        Track,
        /// <summary>
        /// 
        /// </summary>
        Ttm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeatureEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeatureEnum value)
        {
            return value switch
            {
                FeatureEnum.Itm => "itm",
                FeatureEnum.MusicLibrary => "music-library",
                FeatureEnum.Streaming => "streaming",
                FeatureEnum.Track => "track",
                FeatureEnum.Ttm => "ttm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeatureEnum? ToEnum(string value)
        {
            return value switch
            {
                "itm" => FeatureEnum.Itm,
                "music-library" => FeatureEnum.MusicLibrary,
                "streaming" => FeatureEnum.Streaming,
                "track" => FeatureEnum.Track,
                "ttm" => FeatureEnum.Ttm,
                _ => null,
            };
        }
    }
}