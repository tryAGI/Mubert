
#nullable enable

namespace Mubert
{
    /// <summary>
    /// The response data
    /// </summary>
    public sealed partial class GetPublicStreamingGetLinkResponseData
    {
        /// <summary>
        /// The generated streaming link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicStreamingGetLinkResponseData" /> class.
        /// </summary>
        /// <param name="link">
        /// The generated streaming link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicStreamingGetLinkResponseData(
            string? link)
        {
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicStreamingGetLinkResponseData" /> class.
        /// </summary>
        public GetPublicStreamingGetLinkResponseData()
        {
        }
    }
}