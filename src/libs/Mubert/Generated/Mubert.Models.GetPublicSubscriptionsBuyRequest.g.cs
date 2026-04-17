
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicSubscriptionsBuyRequest
    {
        /// <summary>
        /// Example: Acme Inc
        /// </summary>
        /// <example>Acme Inc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Example: contact@acme.com
        /// </summary>
        /// <example>contact@acme.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Example: price_1234567890
        /// </summary>
        /// <example>price_1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_price_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripePriceId { get; set; }

        /// <summary>
        /// Example: https://example.com/success
        /// </summary>
        /// <example>https://example.com/success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Example: https://example.com/cancel
        /// </summary>
        /// <example>https://example.com/cancel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url_cancel")]
        public string? RedirectUrlCancel { get; set; }

        /// <summary>
        /// Example: DISCOUNT20
        /// </summary>
        /// <example>DISCOUNT20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public string? CouponId { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public bool? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicSubscriptionsBuyRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Example: contact@acme.com
        /// </param>
        /// <param name="stripePriceId">
        /// Example: price_1234567890
        /// </param>
        /// <param name="companyName">
        /// Example: Acme Inc
        /// </param>
        /// <param name="redirectUrl">
        /// Example: https://example.com/success
        /// </param>
        /// <param name="redirectUrlCancel">
        /// Example: https://example.com/cancel
        /// </param>
        /// <param name="couponId">
        /// Example: DISCOUNT20
        /// </param>
        /// <param name="redirect">
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicSubscriptionsBuyRequest(
            string email,
            string stripePriceId,
            string? companyName,
            string? redirectUrl,
            string? redirectUrlCancel,
            string? couponId,
            bool? redirect)
        {
            this.CompanyName = companyName;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.StripePriceId = stripePriceId ?? throw new global::System.ArgumentNullException(nameof(stripePriceId));
            this.RedirectUrl = redirectUrl;
            this.RedirectUrlCancel = redirectUrlCancel;
            this.CouponId = couponId;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicSubscriptionsBuyRequest" /> class.
        /// </summary>
        public GetPublicSubscriptionsBuyRequest()
        {
        }
    }
}