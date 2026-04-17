
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified license is not active and cannot be used for the requested operation.
    /// </summary>
    public sealed partial class LicenseIsNotActiveException
    {
        /// <summary>
        /// Example: License is not active
        /// </summary>
        /// <example>License is not active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Attempted operation with an inactive license
        /// </summary>
        /// <example>Attempted operation with an inactive license</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseIsNotActive
        /// </summary>
        /// <example>LicenseIsNotActive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseIsNotActiveException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: License is not active
        /// </param>
        /// <param name="description">
        /// Example: Attempted operation with an inactive license
        /// </param>
        /// <param name="code">
        /// Example: LicenseIsNotActive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseIsNotActiveException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseIsNotActiveException" /> class.
        /// </summary>
        public LicenseIsNotActiveException()
        {
        }
    }
}