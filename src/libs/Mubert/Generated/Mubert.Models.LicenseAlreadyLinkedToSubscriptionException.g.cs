
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license is already linked to a subscription.
    /// </summary>
    public sealed partial class LicenseAlreadyLinkedToSubscriptionException
    {
        /// <summary>
        /// Example: License is already linked to a subscription
        /// </summary>
        /// <example>License is already linked to a subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: The company already has a StripeCustomer and the license has a stripe_subscription_id
        /// </summary>
        /// <example>The company already has a StripeCustomer and the license has a stripe_subscription_id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseAlreadyLinkedToSubscription
        /// </summary>
        /// <example>LicenseAlreadyLinkedToSubscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAlreadyLinkedToSubscriptionException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: License is already linked to a subscription
        /// </param>
        /// <param name="description">
        /// Example: The company already has a StripeCustomer and the license has a stripe_subscription_id
        /// </param>
        /// <param name="code">
        /// Example: LicenseAlreadyLinkedToSubscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseAlreadyLinkedToSubscriptionException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAlreadyLinkedToSubscriptionException" /> class.
        /// </summary>
        public LicenseAlreadyLinkedToSubscriptionException()
        {
        }
    }
}