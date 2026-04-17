
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different track formats.<br/>
    /// Example: mp3
    /// </summary>
    public enum TrackFormatEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackFormatEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackFormatEnum value)
        {
            return value switch
            {
                TrackFormatEnum.Mp3 => "mp3",
                TrackFormatEnum.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackFormatEnum? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => TrackFormatEnum.Mp3,
                "wav" => TrackFormatEnum.Wav,
                _ => null,
            };
        }
    }
}