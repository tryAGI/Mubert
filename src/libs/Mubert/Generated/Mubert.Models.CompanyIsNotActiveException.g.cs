
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the company is inactive, and the requested action is forbidden.
    /// </summary>
    public sealed partial class CompanyIsNotActiveException
    {
        /// <summary>
        /// Example: Company is not active
        /// </summary>
        /// <example>Company is not active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Additional context about the company status
        /// </summary>
        /// <example>Additional context about the company status</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: CompanyIsNotActive
        /// </summary>
        /// <example>CompanyIsNotActive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIsNotActiveException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Company is not active
        /// </param>
        /// <param name="description">
        /// Example: Additional context about the company status
        /// </param>
        /// <param name="code">
        /// Example: CompanyIsNotActive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompanyIsNotActiveException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyIsNotActiveException" /> class.
        /// </summary>
        public CompanyIsNotActiveException()
        {
        }
    }
}