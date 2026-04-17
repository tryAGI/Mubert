
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public enum Error403ResponseDiscriminatorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AccessTokenExpired,
        /// <summary>
        /// 
        /// </summary>
        CompanyIsNotActive,
        /// <summary>
        /// 
        /// </summary>
        CustomerIsNotActive,
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        LicenseExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Error403ResponseDiscriminatorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Error403ResponseDiscriminatorCode value)
        {
            return value switch
            {
                Error403ResponseDiscriminatorCode.AccessTokenExpired => "AccessTokenExpired",
                Error403ResponseDiscriminatorCode.CompanyIsNotActive => "CompanyIsNotActive",
                Error403ResponseDiscriminatorCode.CustomerIsNotActive => "CustomerIsNotActive",
                Error403ResponseDiscriminatorCode.Forbidden => "Forbidden",
                Error403ResponseDiscriminatorCode.LicenseExpired => "LicenseExpired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Error403ResponseDiscriminatorCode? ToEnum(string value)
        {
            return value switch
            {
                "AccessTokenExpired" => Error403ResponseDiscriminatorCode.AccessTokenExpired,
                "CompanyIsNotActive" => Error403ResponseDiscriminatorCode.CompanyIsNotActive,
                "CustomerIsNotActive" => Error403ResponseDiscriminatorCode.CustomerIsNotActive,
                "Forbidden" => Error403ResponseDiscriminatorCode.Forbidden,
                "LicenseExpired" => Error403ResponseDiscriminatorCode.LicenseExpired,
                _ => null,
            };
        }
    }
}