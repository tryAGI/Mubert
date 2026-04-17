
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public enum StripePricePublicResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        OneTime,
        /// <summary>
        /// 
        /// </summary>
        Recurring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripePricePublicResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripePricePublicResourceType value)
        {
            return value switch
            {
                StripePricePublicResourceType.OneTime => "one_time",
                StripePricePublicResourceType.Recurring => "recurring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripePricePublicResourceType? ToEnum(string value)
        {
            return value switch
            {
                "one_time" => StripePricePublicResourceType.OneTime,
                "recurring" => StripePricePublicResourceType.Recurring,
                _ => null,
            };
        }
    }
}