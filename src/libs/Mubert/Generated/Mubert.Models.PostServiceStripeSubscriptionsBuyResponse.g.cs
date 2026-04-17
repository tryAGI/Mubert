
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostServiceStripeSubscriptionsBuyResponse
    {
        /// <summary>
        /// Example: https://checkout.stripe.com/...
        /// </summary>
        /// <example>https://checkout.stripe.com/...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkout_url")]
        public string? CheckoutUrl { get; set; }

        /// <summary>
        /// Example: cs_test_...
        /// </summary>
        /// <example>cs_test_...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceStripeSubscriptionsBuyResponse" /> class.
        /// </summary>
        /// <param name="checkoutUrl">
        /// Example: https://checkout.stripe.com/...
        /// </param>
        /// <param name="sessionId">
        /// Example: cs_test_...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostServiceStripeSubscriptionsBuyResponse(
            string? checkoutUrl,
            string? sessionId)
        {
            this.CheckoutUrl = checkoutUrl;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostServiceStripeSubscriptionsBuyResponse" /> class.
        /// </summary>
        public PostServiceStripeSubscriptionsBuyResponse()
        {
        }
    }
}