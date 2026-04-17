
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Instruments<br/>
    /// Example: DRUMS
    /// </summary>
    public enum InstrumentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Bass,
        /// <summary>
        /// 
        /// </summary>
        Claps,
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
        Hats,
        /// <summary>
        /// 
        /// </summary>
        Impact,
        /// <summary>
        /// 
        /// </summary>
        Leads,
        /// <summary>
        /// 
        /// </summary>
        Mids,
        /// <summary>
        /// 
        /// </summary>
        Pads,
        /// <summary>
        /// 
        /// </summary>
        Percs,
        /// <summary>
        /// 
        /// </summary>
        Riser,
        /// <summary>
        /// 
        /// </summary>
        Vocals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstrumentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstrumentEnum value)
        {
            return value switch
            {
                InstrumentEnum.Bass => "BASS",
                InstrumentEnum.Claps => "CLAPS",
                InstrumentEnum.Drums => "DRUMS",
                InstrumentEnum.Fx => "FX",
                InstrumentEnum.Hats => "HATS",
                InstrumentEnum.Impact => "IMPACT",
                InstrumentEnum.Leads => "LEADS",
                InstrumentEnum.Mids => "MIDS",
                InstrumentEnum.Pads => "PADS",
                InstrumentEnum.Percs => "PERCS",
                InstrumentEnum.Riser => "RISER",
                InstrumentEnum.Vocals => "VOCALS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstrumentEnum? ToEnum(string value)
        {
            return value switch
            {
                "BASS" => InstrumentEnum.Bass,
                "CLAPS" => InstrumentEnum.Claps,
                "DRUMS" => InstrumentEnum.Drums,
                "FX" => InstrumentEnum.Fx,
                "HATS" => InstrumentEnum.Hats,
                "IMPACT" => InstrumentEnum.Impact,
                "LEADS" => InstrumentEnum.Leads,
                "MIDS" => InstrumentEnum.Mids,
                "PADS" => InstrumentEnum.Pads,
                "PERCS" => InstrumentEnum.Percs,
                "RISER" => InstrumentEnum.Riser,
                "VOCALS" => InstrumentEnum.Vocals,
                _ => null,
            };
        }
    }
}