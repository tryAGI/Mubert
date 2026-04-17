
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Customer Track Generation Statuses
    /// </summary>
    public enum TrackGenerationStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackGenerationStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackGenerationStatusEnum value)
        {
            return value switch
            {
                TrackGenerationStatusEnum.Done => "done",
                TrackGenerationStatusEnum.Failed => "failed",
                TrackGenerationStatusEnum.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackGenerationStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "done" => TrackGenerationStatusEnum.Done,
                "failed" => TrackGenerationStatusEnum.Failed,
                "processing" => TrackGenerationStatusEnum.Processing,
                _ => null,
            };
        }
    }
}