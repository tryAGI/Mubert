
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified company could not be found.
    /// </summary>
    public sealed partial class CompanyNotFoundException
    {
        /// <summary>
        /// Error message indicating that the company could not be located.<br/>
        /// Example: Company not found
        /// </summary>
        /// <example>Company not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Optional field providing more context about the missing company.<br/>
        /// Example: Additional details regarding the missing company
        /// </summary>
        /// <example>Additional details regarding the missing company</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique code identifying the company-not-found error.<br/>
        /// Example: CompanyNotFound
        /// </summary>
        /// <example>CompanyNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message indicating that the company could not be located.<br/>
        /// Example: Company not found
        /// </param>
        /// <param name="description">
        /// Optional field providing more context about the missing company.<br/>
        /// Example: Additional details regarding the missing company
        /// </param>
        /// <param name="code">
        /// Unique code identifying the company-not-found error.<br/>
        /// Example: CompanyNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompanyNotFoundException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyNotFoundException" /> class.
        /// </summary>
        public CompanyNotFoundException()
        {
        }
    }
}