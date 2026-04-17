
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified bitrate is not permitted by the current license.
    /// </summary>
    public sealed partial class LicenseForbiddenBitrateException
    {
        /// <summary>
        /// Example: The license does not provide for the use of the specified bitrate
        /// </summary>
        /// <example>The license does not provide for the use of the specified bitrate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Attempted to use a bitrate outside of license permissions
        /// </summary>
        /// <example>Attempted to use a bitrate outside of license permissions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: LicenseForbiddenBitrate
        /// </summary>
        /// <example>LicenseForbiddenBitrate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenBitrateException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The license does not provide for the use of the specified bitrate
        /// </param>
        /// <param name="description">
        /// Example: Attempted to use a bitrate outside of license permissions
        /// </param>
        /// <param name="code">
        /// Example: LicenseForbiddenBitrate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseForbiddenBitrateException(
            string? message,
            string? description,
            string? code)
        {
            this.Message = message;
            this.Description = description;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseForbiddenBitrateException" /> class.
        /// </summary>
        public LicenseForbiddenBitrateException()
        {
        }
    }
}