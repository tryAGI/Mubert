
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the requested action is forbidden due to the company being inactive.
    /// </summary>
    public sealed partial class CustomerIsNotActiveException
    {
        /// <summary>
        /// Example: Customer is not active
        /// </summary>
        /// <example>Customer is not active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Additional context about the company status
        /// </summary>
        /// <example>Additional context about the company status</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: CustomerIsNotActive
        /// </summary>
        /// <example>CustomerIsNotActive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerIsNotActiveException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Customer is not active
        /// </param>
        /// <param name="description">
        /// Example: Additional context about the company status
        /// </param>
        /// <param name="code">
        /// Example: CustomerIsNotActive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerIsNotActiveException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerIsNotActiveException" /> class.
        /// </summary>
        public CustomerIsNotActiveException()
        {
        }
    }
}