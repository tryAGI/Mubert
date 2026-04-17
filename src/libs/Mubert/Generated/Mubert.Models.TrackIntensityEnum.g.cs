
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different intensity levels of a track.<br/>
    /// Example: medium
    /// </summary>
    public enum TrackIntensityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackIntensityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackIntensityEnum value)
        {
            return value switch
            {
                TrackIntensityEnum.High => "high",
                TrackIntensityEnum.Low => "low",
                TrackIntensityEnum.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackIntensityEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => TrackIntensityEnum.High,
                "low" => TrackIntensityEnum.Low,
                "medium" => TrackIntensityEnum.Medium,
                _ => null,
            };
        }
    }
}