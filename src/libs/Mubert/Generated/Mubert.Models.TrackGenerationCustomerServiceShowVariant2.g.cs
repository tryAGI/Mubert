
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackGenerationCustomerServiceShowVariant2
    {
        /// <summary>
        /// Download link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGenerationCustomerServiceShowVariant2" /> class.
        /// </summary>
        /// <param name="url">
        /// Download link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackGenerationCustomerServiceShowVariant2(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGenerationCustomerServiceShowVariant2" /> class.
        /// </summary>
        public TrackGenerationCustomerServiceShowVariant2()
        {
        }
    }
}