
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the subscription is not active.
    /// </summary>
    public sealed partial class SubscriptionIsNotActiveException
    {
        /// <summary>
        /// Example: Subscription is not active
        /// </summary>
        /// <example>Subscription is not active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: The subscription is not currently active
        /// </summary>
        /// <example>The subscription is not currently active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: SubscriptionIsNotActive
        /// </summary>
        /// <example>SubscriptionIsNotActive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIsNotActiveException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Subscription is not active
        /// </param>
        /// <param name="description">
        /// Example: The subscription is not currently active
        /// </param>
        /// <param name="code">
        /// Example: SubscriptionIsNotActive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionIsNotActiveException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIsNotActiveException" /> class.
        /// </summary>
        public SubscriptionIsNotActiveException()
        {
        }
    }
}