
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Stripe Payment Status Enum
    /// </summary>
    public enum StripePaymentIntentStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        RequiresCapture,
        /// <summary>
        /// 
        /// </summary>
        RequiresConfirmation,
        /// <summary>
        /// 
        /// </summary>
        RequiresPaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripePaymentIntentStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripePaymentIntentStatusEnum value)
        {
            return value switch
            {
                StripePaymentIntentStatusEnum.Canceled => "canceled",
                StripePaymentIntentStatusEnum.Processing => "processing",
                StripePaymentIntentStatusEnum.RequiresAction => "requires_action",
                StripePaymentIntentStatusEnum.RequiresCapture => "requires_capture",
                StripePaymentIntentStatusEnum.RequiresConfirmation => "requires_confirmation",
                StripePaymentIntentStatusEnum.RequiresPaymentMethod => "requires_payment_method",
                StripePaymentIntentStatusEnum.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripePaymentIntentStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => StripePaymentIntentStatusEnum.Canceled,
                "processing" => StripePaymentIntentStatusEnum.Processing,
                "requires_action" => StripePaymentIntentStatusEnum.RequiresAction,
                "requires_capture" => StripePaymentIntentStatusEnum.RequiresCapture,
                "requires_confirmation" => StripePaymentIntentStatusEnum.RequiresConfirmation,
                "requires_payment_method" => StripePaymentIntentStatusEnum.RequiresPaymentMethod,
                "succeeded" => StripePaymentIntentStatusEnum.Succeeded,
                _ => null,
            };
        }
    }
}