
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PriceTranslationPublicResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_title")]
        public string? PriceTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_description")]
        public string? PageDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("popup_description")]
        public string? PopupDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        public string? Feature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTranslationPublicResource" /> class.
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="name"></param>
        /// <param name="priceTitle"></param>
        /// <param name="pageDescription"></param>
        /// <param name="popupDescription"></param>
        /// <param name="feature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceTranslationPublicResource(
            string? lang,
            string? name,
            string? priceTitle,
            string? pageDescription,
            string? popupDescription,
            string? feature)
        {
            this.Lang = lang;
            this.Name = name;
            this.PriceTitle = priceTitle;
            this.PageDescription = pageDescription;
            this.PopupDescription = popupDescription;
            this.Feature = feature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTranslationPublicResource" /> class.
        /// </summary>
        public PriceTranslationPublicResource()
        {
        }
    }
}