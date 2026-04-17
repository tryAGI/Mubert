
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetServiceStripeBillingPortalRequest
    {
        /// <summary>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CompanyId { get; set; }

        /// <summary>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LicenseToken { get; set; }

        /// <summary>
        /// URL to return to after leaving the billing portal<br/>
        /// Example: https://mubert.com/success
        /// </summary>
        /// <example>https://mubert.com/success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceStripeBillingPortalRequest" /> class.
        /// </summary>
        /// <param name="companyId">
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="licenseToken">
        /// Example: abc123def456
        /// </param>
        /// <param name="redirectUrl">
        /// URL to return to after leaving the billing portal<br/>
        /// Example: https://mubert.com/success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetServiceStripeBillingPortalRequest(
            global::System.Guid companyId,
            string licenseToken,
            string? redirectUrl)
        {
            this.CompanyId = companyId;
            this.LicenseToken = licenseToken ?? throw new global::System.ArgumentNullException(nameof(licenseToken));
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceStripeBillingPortalRequest" /> class.
        /// </summary>
        public GetServiceStripeBillingPortalRequest()
        {
        }
    }
}