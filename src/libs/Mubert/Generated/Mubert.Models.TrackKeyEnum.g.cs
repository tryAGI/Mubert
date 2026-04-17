
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different musical keys for a track.<br/>
    /// Example: C#
    /// </summary>
    public enum TrackKeyEnum
    {
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        A_,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        B,
        /// <summary>
        /// 
        /// </summary>
        C,
        /// <summary>
        /// 
        /// </summary>
        C_,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        D_,
        /// <summary>
        /// 
        /// </summary>
        E,
        /// <summary>
        /// 
        /// </summary>
        F,
        /// <summary>
        /// 
        /// </summary>
        F_,
        /// <summary>
        /// 
        /// </summary>
        G,
        /// <summary>
        /// 
        /// </summary>
        G_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackKeyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackKeyEnum value)
        {
            return value switch
            {
                TrackKeyEnum.A => "A",
                TrackKeyEnum.A_ => "A#",
                TrackKeyEnum.All => "ALL",
                TrackKeyEnum.B => "B",
                TrackKeyEnum.C => "C",
                TrackKeyEnum.C_ => "C#",
                TrackKeyEnum.D => "D",
                TrackKeyEnum.D_ => "D#",
                TrackKeyEnum.E => "E",
                TrackKeyEnum.F => "F",
                TrackKeyEnum.F_ => "F#",
                TrackKeyEnum.G => "G",
                TrackKeyEnum.G_ => "G#",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackKeyEnum? ToEnum(string value)
        {
            return value switch
            {
                "A" => TrackKeyEnum.A,
                "A#" => TrackKeyEnum.A_,
                "ALL" => TrackKeyEnum.All,
                "B" => TrackKeyEnum.B,
                "C" => TrackKeyEnum.C,
                "C#" => TrackKeyEnum.C_,
                "D" => TrackKeyEnum.D,
                "D#" => TrackKeyEnum.D_,
                "E" => TrackKeyEnum.E,
                "F" => TrackKeyEnum.F,
                "F#" => TrackKeyEnum.F_,
                "G" => TrackKeyEnum.G,
                "G#" => TrackKeyEnum.G_,
                _ => null,
            };
        }
    }
}