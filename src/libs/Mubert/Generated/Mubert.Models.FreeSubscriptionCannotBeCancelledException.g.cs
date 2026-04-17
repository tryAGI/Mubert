
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that a free subscription cannot be cancelled.
    /// </summary>
    public sealed partial class FreeSubscriptionCannotBeCancelledException
    {
        /// <summary>
        /// Example: Free subscription cannot be cancelled
        /// </summary>
        /// <example>Free subscription cannot be cancelled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Free subscriptions do not have a cancellation option
        /// </summary>
        /// <example>Free subscriptions do not have a cancellation option</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: FreeSubscriptionCannotBeCancelled
        /// </summary>
        /// <example>FreeSubscriptionCannotBeCancelled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeSubscriptionCannotBeCancelledException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Free subscription cannot be cancelled
        /// </param>
        /// <param name="description">
        /// Example: Free subscriptions do not have a cancellation option
        /// </param>
        /// <param name="code">
        /// Example: FreeSubscriptionCannotBeCancelled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FreeSubscriptionCannotBeCancelledException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeSubscriptionCannotBeCancelledException" /> class.
        /// </summary>
        public FreeSubscriptionCannotBeCancelledException()
        {
        }
    }
}