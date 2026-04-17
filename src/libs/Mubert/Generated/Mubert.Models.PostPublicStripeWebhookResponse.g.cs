
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicStripeWebhookResponse
    {
        /// <summary>
        /// Example: Invalid signature
        /// </summary>
        /// <example>Invalid signature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStripeWebhookResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Invalid signature
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicStripeWebhookResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStripeWebhookResponse" /> class.
        /// </summary>
        public PostPublicStripeWebhookResponse()
        {
        }
    }
}