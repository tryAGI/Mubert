
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Enumeration representing different buckets.<br/>
    /// Example: static-eu.mubert.com
    /// </summary>
    public enum BucketEnum
    {
        /// <summary>
        /// 
        /// </summary>
        InternalEuMubertCom,
        /// <summary>
        /// 
        /// </summary>
        StaticEuMubertCom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BucketEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BucketEnum value)
        {
            return value switch
            {
                BucketEnum.InternalEuMubertCom => "internal-eu.mubert.com",
                BucketEnum.StaticEuMubertCom => "static-eu.mubert.com",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BucketEnum? ToEnum(string value)
        {
            return value switch
            {
                "internal-eu.mubert.com" => BucketEnum.InternalEuMubertCom,
                "static-eu.mubert.com" => BucketEnum.StaticEuMubertCom,
                _ => null,
            };
        }
    }
}