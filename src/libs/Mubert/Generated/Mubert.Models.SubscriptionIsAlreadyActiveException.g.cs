
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the subscription is already active.
    /// </summary>
    public sealed partial class SubscriptionIsAlreadyActiveException
    {
        /// <summary>
        /// Example: Subscription is already active
        /// </summary>
        /// <example>Subscription is already active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: The company already has an active subscription
        /// </summary>
        /// <example>The company already has an active subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: SubscriptionIsAlreadyActive
        /// </summary>
        /// <example>SubscriptionIsAlreadyActive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIsAlreadyActiveException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Subscription is already active
        /// </param>
        /// <param name="description">
        /// Example: The company already has an active subscription
        /// </param>
        /// <param name="code">
        /// Example: SubscriptionIsAlreadyActive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionIsAlreadyActiveException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIsAlreadyActiveException" /> class.
        /// </summary>
        public SubscriptionIsAlreadyActiveException()
        {
        }
    }
}