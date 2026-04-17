
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different modes of a track.<br/>
    /// Example: loop
    /// </summary>
    public enum TrackModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Jingle,
        /// <summary>
        /// 
        /// </summary>
        Loop,
        /// <summary>
        /// 
        /// </summary>
        Mix,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackModeEnum value)
        {
            return value switch
            {
                TrackModeEnum.Jingle => "jingle",
                TrackModeEnum.Loop => "loop",
                TrackModeEnum.Mix => "mix",
                TrackModeEnum.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "jingle" => TrackModeEnum.Jingle,
                "loop" => TrackModeEnum.Loop,
                "mix" => TrackModeEnum.Mix,
                "track" => TrackModeEnum.Track,
                _ => null,
            };
        }
    }
}