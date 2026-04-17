
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the user does not have permission to access the resource.
    /// </summary>
    public sealed partial class ForbiddenException
    {
        /// <summary>
        /// Example: You don’t have permission to access this resource
        /// </summary>
        /// <example>You don’t have permission to access this resource</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Detailed reason for the access denial
        /// </summary>
        /// <example>Detailed reason for the access denial</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: Forbidden
        /// </summary>
        /// <example>Forbidden</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: You don’t have permission to access this resource
        /// </param>
        /// <param name="description">
        /// Example: Detailed reason for the access denial
        /// </param>
        /// <param name="code">
        /// Example: Forbidden
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForbiddenException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        public ForbiddenException()
        {
        }
    }
}