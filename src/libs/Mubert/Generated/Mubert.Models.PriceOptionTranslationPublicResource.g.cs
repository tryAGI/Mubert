
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PriceOptionTranslationPublicResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceOptionTranslationPublicResource" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceOptionTranslationPublicResource(
            string? locale,
            string? title)
        {
            this.Locale = locale;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceOptionTranslationPublicResource" /> class.
        /// </summary>
        public PriceOptionTranslationPublicResource()
        {
        }
    }
}