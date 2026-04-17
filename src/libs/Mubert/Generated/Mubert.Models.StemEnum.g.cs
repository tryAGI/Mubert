
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stems<br/>
    /// Example: DRUMS
    /// </summary>
    public enum StemEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Bass,
        /// <summary>
        /// 
        /// </summary>
        Drums,
        /// <summary>
        /// 
        /// </summary>
        Fx,
        /// <summary>
        /// 
        /// </summary>
        Leads,
        /// <summary>
        /// 
        /// </summary>
        Vocals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StemEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StemEnum value)
        {
            return value switch
            {
                StemEnum.Bass => "BASS",
                StemEnum.Drums => "DRUMS",
                StemEnum.Fx => "FX",
                StemEnum.Leads => "LEADS",
                StemEnum.Vocals => "VOCALS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StemEnum? ToEnum(string value)
        {
            return value switch
            {
                "BASS" => StemEnum.Bass,
                "DRUMS" => StemEnum.Drums,
                "FX" => StemEnum.Fx,
                "LEADS" => StemEnum.Leads,
                "VOCALS" => StemEnum.Vocals,
                _ => null,
            };
        }
    }
}