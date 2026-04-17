
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the Stripe customer could not be found.
    /// </summary>
    public sealed partial class StripeCustomerNotFoundException
    {
        /// <summary>
        /// Example: Stripe customer not found
        /// </summary>
        /// <example>Stripe customer not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: No Stripe customer exists with the specified ID
        /// </summary>
        /// <example>No Stripe customer exists with the specified ID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: StripeCustomerNotFound
        /// </summary>
        /// <example>StripeCustomerNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Stripe customer not found
        /// </param>
        /// <param name="description">
        /// Example: No Stripe customer exists with the specified ID
        /// </param>
        /// <param name="code">
        /// Example: StripeCustomerNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeCustomerNotFoundException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerNotFoundException" /> class.
        /// </summary>
        public StripeCustomerNotFoundException()
        {
        }
    }
}