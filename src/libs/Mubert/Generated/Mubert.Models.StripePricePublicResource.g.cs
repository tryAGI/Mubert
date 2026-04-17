
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripePricePublicResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        public string? PriceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.StripePricePublicResourceTypeJsonConverter))]
        public global::Mubert.StripePricePublicResourceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.StripePricePublicResourceIntervalJsonConverter))]
        public global::Mubert.StripePricePublicResourceInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePricePublicResource" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="priceId"></param>
        /// <param name="productId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="interval"></param>
        /// <param name="amount"></param>
        /// <param name="trialPeriodDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripePricePublicResource(
            global::System.Guid? id,
            string? priceId,
            string? productId,
            string? name,
            global::Mubert.StripePricePublicResourceType? type,
            global::Mubert.StripePricePublicResourceInterval? interval,
            int? amount,
            int? trialPeriodDays)
        {
            this.Id = id;
            this.PriceId = priceId;
            this.ProductId = productId;
            this.Name = name;
            this.Type = type;
            this.Interval = interval;
            this.Amount = amount;
            this.TrialPeriodDays = trialPeriodDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePricePublicResource" /> class.
        /// </summary>
        public StripePricePublicResource()
        {
        }
    }
}