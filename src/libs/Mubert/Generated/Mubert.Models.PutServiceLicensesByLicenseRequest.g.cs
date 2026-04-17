
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutServiceLicensesByLicenseRequest
    {
        /// <summary>
        /// The URL for the webhook.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// A flag indicating whether the webhook is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_enabled")]
        public bool? WebhookEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutServiceLicensesByLicenseRequest" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// The URL for the webhook.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="webhookEnabled">
        /// A flag indicating whether the webhook is enabled.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutServiceLicensesByLicenseRequest(
            string? webhookUrl,
            bool? webhookEnabled)
        {
            this.WebhookUrl = webhookUrl;
            this.WebhookEnabled = webhookEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutServiceLicensesByLicenseRequest" /> class.
        /// </summary>
        public PutServiceLicensesByLicenseRequest()
        {
        }
    }
}