
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the user is not authenticated to access the resource.
    /// </summary>
    public sealed partial class UnauthenticatedException
    {
        /// <summary>
        /// Example: Unauthenticated
        /// </summary>
        /// <example>Unauthenticated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Reason for authentication failure
        /// </summary>
        /// <example>Reason for authentication failure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: Unauthenticated
        /// </summary>
        /// <example>Unauthenticated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthenticatedException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthenticated
        /// </param>
        /// <param name="description">
        /// Example: Reason for authentication failure
        /// </param>
        /// <param name="code">
        /// Example: Unauthenticated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnauthenticatedException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthenticatedException" /> class.
        /// </summary>
        public UnauthenticatedException()
        {
        }
    }
}