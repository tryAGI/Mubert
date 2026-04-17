
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Key-Scale for a track.<br/>
    /// Example: C#
    /// </summary>
    public enum TrackKeyScaleEnum
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
        A_m,
        /// <summary>
        /// 
        /// </summary>
        Am,
        /// <summary>
        /// 
        /// </summary>
        B,
        /// <summary>
        /// 
        /// </summary>
        Bm,
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
        C_m,
        /// <summary>
        /// 
        /// </summary>
        Cm,
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
        D_m,
        /// <summary>
        /// 
        /// </summary>
        Dm,
        /// <summary>
        /// 
        /// </summary>
        E,
        /// <summary>
        /// 
        /// </summary>
        Em,
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
        F_m,
        /// <summary>
        /// 
        /// </summary>
        Fm,
        /// <summary>
        /// 
        /// </summary>
        G,
        /// <summary>
        /// 
        /// </summary>
        G_,
        /// <summary>
        /// 
        /// </summary>
        G_m,
        /// <summary>
        /// 
        /// </summary>
        Gm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackKeyScaleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackKeyScaleEnum value)
        {
            return value switch
            {
                TrackKeyScaleEnum.A => "A",
                TrackKeyScaleEnum.A_ => "A#",
                TrackKeyScaleEnum.A_m => "A#m",
                TrackKeyScaleEnum.Am => "Am",
                TrackKeyScaleEnum.B => "B",
                TrackKeyScaleEnum.Bm => "Bm",
                TrackKeyScaleEnum.C => "C",
                TrackKeyScaleEnum.C_ => "C#",
                TrackKeyScaleEnum.C_m => "C#m",
                TrackKeyScaleEnum.Cm => "Cm",
                TrackKeyScaleEnum.D => "D",
                TrackKeyScaleEnum.D_ => "D#",
                TrackKeyScaleEnum.D_m => "D#m",
                TrackKeyScaleEnum.Dm => "Dm",
                TrackKeyScaleEnum.E => "E",
                TrackKeyScaleEnum.Em => "Em",
                TrackKeyScaleEnum.F => "F",
                TrackKeyScaleEnum.F_ => "F#",
                TrackKeyScaleEnum.F_m => "F#m",
                TrackKeyScaleEnum.Fm => "Fm",
                TrackKeyScaleEnum.G => "G",
                TrackKeyScaleEnum.G_ => "G#",
                TrackKeyScaleEnum.G_m => "G#m",
                TrackKeyScaleEnum.Gm => "Gm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackKeyScaleEnum? ToEnum(string value)
        {
            return value switch
            {
                "A" => TrackKeyScaleEnum.A,
                "A#" => TrackKeyScaleEnum.A_,
                "A#m" => TrackKeyScaleEnum.A_m,
                "Am" => TrackKeyScaleEnum.Am,
                "B" => TrackKeyScaleEnum.B,
                "Bm" => TrackKeyScaleEnum.Bm,
                "C" => TrackKeyScaleEnum.C,
                "C#" => TrackKeyScaleEnum.C_,
                "C#m" => TrackKeyScaleEnum.C_m,
                "Cm" => TrackKeyScaleEnum.Cm,
                "D" => TrackKeyScaleEnum.D,
                "D#" => TrackKeyScaleEnum.D_,
                "D#m" => TrackKeyScaleEnum.D_m,
                "Dm" => TrackKeyScaleEnum.Dm,
                "E" => TrackKeyScaleEnum.E,
                "Em" => TrackKeyScaleEnum.Em,
                "F" => TrackKeyScaleEnum.F,
                "F#" => TrackKeyScaleEnum.F_,
                "F#m" => TrackKeyScaleEnum.F_m,
                "Fm" => TrackKeyScaleEnum.Fm,
                "G" => TrackKeyScaleEnum.G,
                "G#" => TrackKeyScaleEnum.G_,
                "G#m" => TrackKeyScaleEnum.G_m,
                "Gm" => TrackKeyScaleEnum.Gm,
                _ => null,
            };
        }
    }
}