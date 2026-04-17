
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Streaming Loop State
    /// </summary>
    public enum StreamingLoopStateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingLoopStateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingLoopStateEnum value)
        {
            return value switch
            {
                StreamingLoopStateEnum.Off => "off",
                StreamingLoopStateEnum.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingLoopStateEnum? ToEnum(string value)
        {
            return value switch
            {
                "off" => StreamingLoopStateEnum.Off,
                "on" => StreamingLoopStateEnum.On,
                _ => null,
            };
        }
    }
}