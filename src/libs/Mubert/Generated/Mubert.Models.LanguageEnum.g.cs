
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Languages
    /// </summary>
    public enum LanguageEnum
    {
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Pt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageEnum value)
        {
            return value switch
            {
                LanguageEnum.De => "de",
                LanguageEnum.Es => "es",
                LanguageEnum.Fr => "fr",
                LanguageEnum.Ja => "ja",
                LanguageEnum.Ko => "ko",
                LanguageEnum.Pt => "pt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageEnum? ToEnum(string value)
        {
            return value switch
            {
                "de" => LanguageEnum.De,
                "es" => LanguageEnum.Es,
                "fr" => LanguageEnum.Fr,
                "ja" => LanguageEnum.Ja,
                "ko" => LanguageEnum.Ko,
                "pt" => LanguageEnum.Pt,
                _ => null,
            };
        }
    }
}