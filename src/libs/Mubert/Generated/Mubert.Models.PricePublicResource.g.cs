
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricePublicResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        public string? Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_price")]
        public global::Mubert.StripePricePublicResource? StripePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Mubert.PriceOptionPublicResource>? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        public global::Mubert.PriceLimitPublicResource? Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePublicResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="feature"></param>
        /// <param name="stripePrice"></param>
        /// <param name="options"></param>
        /// <param name="limits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricePublicResource(
            global::System.Guid? id,
            string? name,
            string? feature,
            global::Mubert.StripePricePublicResource? stripePrice,
            global::System.Collections.Generic.IList<global::Mubert.PriceOptionPublicResource>? options,
            global::Mubert.PriceLimitPublicResource? limits)
        {
            this.Id = id;
            this.Name = name;
            this.Feature = feature;
            this.StripePrice = stripePrice;
            this.Options = options;
            this.Limits = limits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePublicResource" /> class.
        /// </summary>
        public PricePublicResource()
        {
        }
    }
}