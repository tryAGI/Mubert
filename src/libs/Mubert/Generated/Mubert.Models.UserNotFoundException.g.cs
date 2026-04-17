
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the requested user was not found or is inaccessible.
    /// </summary>
    public sealed partial class UserNotFoundException
    {
        /// <summary>
        /// Error message indicating that the user could not be found.<br/>
        /// Example: User not found
        /// </summary>
        /// <example>User not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Optional field providing more context on why the user is inaccessible.<br/>
        /// Example: Additional details about why the user was not found
        /// </summary>
        /// <example>Additional details about why the user was not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique code identifying the user-not-found error.<br/>
        /// Example: UserNotFound
        /// </summary>
        /// <example>UserNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message indicating that the user could not be found.<br/>
        /// Example: User not found
        /// </param>
        /// <param name="description">
        /// Optional field providing more context on why the user is inaccessible.<br/>
        /// Example: Additional details about why the user was not found
        /// </param>
        /// <param name="code">
        /// Unique code identifying the user-not-found error.<br/>
        /// Example: UserNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserNotFoundException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserNotFoundException" /> class.
        /// </summary>
        public UserNotFoundException()
        {
        }
    }
}