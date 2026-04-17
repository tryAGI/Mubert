
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Invoice Status Enum
    /// </summary>
    public enum StripeInvoiceStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        Uncollectible,
        /// <summary>
        /// 
        /// </summary>
        Void,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripeInvoiceStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripeInvoiceStatusEnum value)
        {
            return value switch
            {
                StripeInvoiceStatusEnum.Draft => "draft",
                StripeInvoiceStatusEnum.Open => "open",
                StripeInvoiceStatusEnum.Paid => "paid",
                StripeInvoiceStatusEnum.Uncollectible => "uncollectible",
                StripeInvoiceStatusEnum.Void => "void",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripeInvoiceStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "draft" => StripeInvoiceStatusEnum.Draft,
                "open" => StripeInvoiceStatusEnum.Open,
                "paid" => StripeInvoiceStatusEnum.Paid,
                "uncollectible" => StripeInvoiceStatusEnum.Uncollectible,
                "void" => StripeInvoiceStatusEnum.Void,
                _ => null,
            };
        }
    }
}