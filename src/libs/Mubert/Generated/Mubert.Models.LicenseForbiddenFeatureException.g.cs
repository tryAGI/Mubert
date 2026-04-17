
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified feature is not permitted by the current license.
    /// </summary>
    public sealed partial class LicenseForbiddenFeatureException
    {
        /// <summary>
        /// Example: The license does not provide for the use of the specified feature
        /// </summary>
        /// <example>The license does not provide for the use of the specified feature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Attempted to access a feature not allowed by the license
        /// </summary>
        /// <example>Attempted to access a feature not allowed by the license</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseForbiddenFeature
        /// </summary>
        /// <example>LicenseForbiddenFeature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenFeatureException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The license does not provide for the use of the specified feature
        /// </param>
        /// <param name="description">
        /// Example: Attempted to access a feature not allowed by the license
        /// </param>
        /// <param name="code">
        /// Example: LicenseForbiddenFeature
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseForbiddenFeatureException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenFeatureException" /> class.
        /// </summary>
        public LicenseForbiddenFeatureException()
        {
        }
    }
}