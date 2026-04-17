
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different musical scale for a track.<br/>
    /// Example: MINOR
    /// </summary>
    public enum TrackScaleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Major,
        /// <summary>
        /// 
        /// </summary>
        Minor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackScaleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackScaleEnum value)
        {
            return value switch
            {
                TrackScaleEnum.All => "ALL",
                TrackScaleEnum.Major => "MAJOR",
                TrackScaleEnum.Minor => "MINOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackScaleEnum? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => TrackScaleEnum.All,
                "MAJOR" => TrackScaleEnum.Major,
                "MINOR" => TrackScaleEnum.Minor,
                _ => null,
            };
        }
    }
}