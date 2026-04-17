
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicStreamingGetLinkResponse
    {
        /// <summary>
        /// The response data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Mubert.GetPublicStreamingGetLinkResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicStreamingGetLinkResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The response data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicStreamingGetLinkResponse(
            global::Mubert.GetPublicStreamingGetLinkResponseData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicStreamingGetLinkResponse" /> class.
        /// </summary>
        public GetPublicStreamingGetLinkResponse()
        {
        }
    }
}