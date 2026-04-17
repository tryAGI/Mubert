
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response for not found errors
    /// </summary>
    public sealed partial class Error404Response
    {
        /// <summary>
        /// Type of the error<br/>
        /// Example: CompanyNotFound
        /// </summary>
        /// <example>CompanyNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Example: Resource not found
        /// </summary>
        /// <example>Resource not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error404Response" /> class.
        /// </summary>
        /// <param name="code">
        /// Type of the error<br/>
        /// Example: CompanyNotFound
        /// </param>
        /// <param name="message">
        /// Example: Resource not found
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error404Response(
            string? code,
            string? message,
            string? description)
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error404Response" /> class.
        /// </summary>
        public Error404Response()
        {
        }
    }
}