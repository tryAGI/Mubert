
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that a Stripe order needs to be placed.
    /// </summary>
    public sealed partial class StripeNeedPlaceOrderException
    {
        /// <summary>
        /// Example: Need to place an order
        /// </summary>
        /// <example>Need to place an order</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Please complete the payment process
        /// </summary>
        /// <example>Please complete the payment process</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: StripeNeedPlaceOrder
        /// </summary>
        /// <example>StripeNeedPlaceOrder</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Example: https://checkout.stripe.com/...
        /// </summary>
        /// <example>https://checkout.stripe.com/...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout_url")]
        public string? CheckoutUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeNeedPlaceOrderException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Need to place an order
        /// </param>
        /// <param name="description">
        /// Example: Please complete the payment process
        /// </param>
        /// <param name="code">
        /// Example: StripeNeedPlaceOrder
        /// </param>
        /// <param name="checkoutUrl">
        /// Example: https://checkout.stripe.com/...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeNeedPlaceOrderException(
            string? message,
            string? description,
            string? code,
            string? checkoutUrl)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
            this.CheckoutUrl = checkoutUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeNeedPlaceOrderException" /> class.
        /// </summary>
        public StripeNeedPlaceOrderException()
        {
        }
    }
}