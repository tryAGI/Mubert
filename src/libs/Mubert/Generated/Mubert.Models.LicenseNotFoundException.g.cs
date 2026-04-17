
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified license could not be found.
    /// </summary>
    public sealed partial class LicenseNotFoundException
    {
        /// <summary>
        /// Example: License not found
        /// </summary>
        /// <example>License not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: No license exists with the specified ID
        /// </summary>
        /// <example>No license exists with the specified ID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseNotFound
        /// </summary>
        /// <example>LicenseNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: License not found
        /// </param>
        /// <param name="description">
        /// Example: No license exists with the specified ID
        /// </param>
        /// <param name="code">
        /// Example: LicenseNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseNotFoundException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseNotFoundException" /> class.
        /// </summary>
        public LicenseNotFoundException()
        {
        }
    }
}