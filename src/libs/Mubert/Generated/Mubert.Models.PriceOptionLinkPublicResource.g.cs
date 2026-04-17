
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PriceOptionLinkPublicResource
    {
        /// <summary>
        /// Shows whether the option is enabled or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceOptionLinkPublicResource" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Shows whether the option is enabled or not
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceOptionLinkPublicResource(
            bool? isEnabled)
        {
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceOptionLinkPublicResource" /> class.
        /// </summary>
        public PriceOptionLinkPublicResource()
        {
        }
    }
}