
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Invoice Billing Reason Enum
    /// </summary>
    public enum StripeInvoiceBillingReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCreate,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCycle,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripeInvoiceBillingReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripeInvoiceBillingReasonEnum value)
        {
            return value switch
            {
                StripeInvoiceBillingReasonEnum.Manual => "manual",
                StripeInvoiceBillingReasonEnum.SubscriptionCreate => "subscription_create",
                StripeInvoiceBillingReasonEnum.SubscriptionCycle => "subscription_cycle",
                StripeInvoiceBillingReasonEnum.SubscriptionUpdate => "subscription_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripeInvoiceBillingReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "manual" => StripeInvoiceBillingReasonEnum.Manual,
                "subscription_create" => StripeInvoiceBillingReasonEnum.SubscriptionCreate,
                "subscription_cycle" => StripeInvoiceBillingReasonEnum.SubscriptionCycle,
                "subscription_update" => StripeInvoiceBillingReasonEnum.SubscriptionUpdate,
                _ => null,
            };
        }
    }
}