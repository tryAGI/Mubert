
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Subscription Status Enum
    /// </summary>
    public enum StripeSubscriptionStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        IncompleteExpired,
        /// <summary>
        /// 
        /// </summary>
        PastDue,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Trialing,
        /// <summary>
        /// 
        /// </summary>
        Unpaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripeSubscriptionStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripeSubscriptionStatusEnum value)
        {
            return value switch
            {
                StripeSubscriptionStatusEnum.Active => "active",
                StripeSubscriptionStatusEnum.Canceled => "canceled",
                StripeSubscriptionStatusEnum.Incomplete => "incomplete",
                StripeSubscriptionStatusEnum.IncompleteExpired => "incomplete_expired",
                StripeSubscriptionStatusEnum.PastDue => "past_due",
                StripeSubscriptionStatusEnum.Paused => "paused",
                StripeSubscriptionStatusEnum.Trialing => "trialing",
                StripeSubscriptionStatusEnum.Unpaid => "unpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripeSubscriptionStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "active" => StripeSubscriptionStatusEnum.Active,
                "canceled" => StripeSubscriptionStatusEnum.Canceled,
                "incomplete" => StripeSubscriptionStatusEnum.Incomplete,
                "incomplete_expired" => StripeSubscriptionStatusEnum.IncompleteExpired,
                "past_due" => StripeSubscriptionStatusEnum.PastDue,
                "paused" => StripeSubscriptionStatusEnum.Paused,
                "trialing" => StripeSubscriptionStatusEnum.Trialing,
                "unpaid" => StripeSubscriptionStatusEnum.Unpaid,
                _ => null,
            };
        }
    }
}