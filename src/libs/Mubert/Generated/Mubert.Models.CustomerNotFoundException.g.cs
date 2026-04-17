
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified customer ID does not match any active record in the database.
    /// </summary>
    public sealed partial class CustomerNotFoundException
    {
        /// <summary>
        /// Example: Customer not found
        /// </summary>
        /// <example>Customer not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Additional details regarding the missing customer
        /// </summary>
        /// <example>Additional details regarding the missing customer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: CustomerNotFound
        /// </summary>
        /// <example>CustomerNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Customer not found
        /// </param>
        /// <param name="description">
        /// Example: Additional details regarding the missing customer
        /// </param>
        /// <param name="code">
        /// Example: CustomerNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerNotFoundException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerNotFoundException" /> class.
        /// </summary>
        public CustomerNotFoundException()
        {
        }
    }
}