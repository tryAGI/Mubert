
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicMusicLibraryTracksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackIndexPublicResource>? Data { get; set; }

        /// <summary>
        /// Pagination metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Mubert.MetadataPagination? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryTracksResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta">
        /// Pagination metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicMusicLibraryTracksResponse(
            global::System.Collections.Generic.IList<global::Mubert.TrackIndexPublicResource>? data,
            global::Mubert.MetadataPagination? meta)
        {
            this.Data = data;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryTracksResponse" /> class.
        /// </summary>
        public GetPublicMusicLibraryTracksResponse()
        {
        }
    }
}