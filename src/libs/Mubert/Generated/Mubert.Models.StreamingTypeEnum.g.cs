
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Streaming Type Enum
    /// </summary>
    public enum StreamingTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Webrtc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingTypeEnum value)
        {
            return value switch
            {
                StreamingTypeEnum.Http => "http",
                StreamingTypeEnum.Webrtc => "webrtc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "http" => StreamingTypeEnum.Http,
                "webrtc" => StreamingTypeEnum.Webrtc,
                _ => null,
            };
        }
    }
}