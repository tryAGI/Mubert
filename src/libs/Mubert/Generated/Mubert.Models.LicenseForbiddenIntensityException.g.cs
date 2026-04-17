
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified intensity level is not permitted by the current license.
    /// </summary>
    public sealed partial class LicenseForbiddenIntensityException
    {
        /// <summary>
        /// Example: The license does not provide for the use of the specified intensity
        /// </summary>
        /// <example>The license does not provide for the use of the specified intensity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Attempted to access an intensity level not allowed by the license
        /// </summary>
        /// <example>Attempted to access an intensity level not allowed by the license</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseForbiddenIntensity
        /// </summary>
        /// <example>LicenseForbiddenIntensity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenIntensityException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The license does not provide for the use of the specified intensity
        /// </param>
        /// <param name="description">
        /// Example: Attempted to access an intensity level not allowed by the license
        /// </param>
        /// <param name="code">
        /// Example: LicenseForbiddenIntensity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseForbiddenIntensityException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenIntensityException" /> class.
        /// </summary>
        public LicenseForbiddenIntensityException()
        {
        }
    }
}