
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the specified license has expired and access is forbidden.
    /// </summary>
    public sealed partial class LicenseExpiredException
    {
        /// <summary>
        /// Example: License is expired
        /// </summary>
        /// <example>License is expired</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: 2023-12-31T23:59:59Z
        /// </summary>
        /// <example>2023-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// Example: LicenseExpired
        /// </summary>
        /// <example>LicenseExpired</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseExpiredException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: License is expired
        /// </param>
        /// <param name="expiredAt">
        /// Example: 2023-12-31T23:59:59Z
        /// </param>
        /// <param name="code">
        /// Example: LicenseExpired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseExpiredException(
            string? message,
            global::System.DateTime? expiredAt,
            string? code)
        {
            this.Message = message;
            this.ExpiredAt = expiredAt;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseExpiredException" /> class.
        /// </summary>
        public LicenseExpiredException()
        {
        }
    }
}