
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating a Stripe error.
    /// </summary>
    public sealed partial class StripeException
    {
        /// <summary>
        /// Example: Stripe error
        /// </summary>
        /// <example>Stripe error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: An error occurred while processing the Stripe request
        /// </summary>
        /// <example>An error occurred while processing the Stripe request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: StripeError
        /// </summary>
        /// <example>StripeError</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Stripe error
        /// </param>
        /// <param name="description">
        /// Example: An error occurred while processing the Stripe request
        /// </param>
        /// <param name="code">
        /// Example: StripeError
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeException" /> class.
        /// </summary>
        public StripeException()
        {
        }
    }
}