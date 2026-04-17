
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessTokenServiceResource
    {
        /// <summary>
        /// Access Token ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Customer ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        public global::System.Guid? CustomerId { get; set; }

        /// <summary>
        /// License ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_id")]
        public global::System.Guid? LicenseId { get; set; }

        /// <summary>
        /// Access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// License
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public global::Mubert.LicenseServiceResource? License { get; set; }

        /// <summary>
        /// Current license limit of the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_limits")]
        public global::Mubert.CustomerLicenseLimitServiceResource? CustomerLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenServiceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Access Token ID
        /// </param>
        /// <param name="customerId">
        /// Customer ID
        /// </param>
        /// <param name="licenseId">
        /// License ID
        /// </param>
        /// <param name="token">
        /// Access token
        /// </param>
        /// <param name="expiredAt">
        /// Expiration timestamp
        /// </param>
        /// <param name="license">
        /// License
        /// </param>
        /// <param name="customerLimits">
        /// Current license limit of the customer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessTokenServiceResource(
            global::System.Guid? id,
            global::System.Guid? customerId,
            global::System.Guid? licenseId,
            string? token,
            global::System.DateTime? expiredAt,
            global::Mubert.LicenseServiceResource? license,
            global::Mubert.CustomerLicenseLimitServiceResource? customerLimits)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.LicenseId = licenseId;
            this.Token = token;
            this.ExpiredAt = expiredAt;
            this.License = license;
            this.CustomerLimits = customerLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenServiceResource" /> class.
        /// </summary>
        public AccessTokenServiceResource()
        {
        }
    }
}