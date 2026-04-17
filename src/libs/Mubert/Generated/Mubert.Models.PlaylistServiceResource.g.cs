
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaylistServiceResource
    {
        /// <summary>
        /// Unique playlist index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_index")]
        public string? PlaylistIndex { get; set; }

        /// <summary>
        /// Category name of the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Group name of the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Channel name of the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistServiceResource" /> class.
        /// </summary>
        /// <param name="playlistIndex">
        /// Unique playlist index
        /// </param>
        /// <param name="category">
        /// Category name of the playlist
        /// </param>
        /// <param name="group">
        /// Group name of the playlist
        /// </param>
        /// <param name="channel">
        /// Channel name of the playlist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistServiceResource(
            string? playlistIndex,
            string? category,
            string? group,
            string? channel)
        {
            this.PlaylistIndex = playlistIndex;
            this.Category = category;
            this.Group = group;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistServiceResource" /> class.
        /// </summary>
        public PlaylistServiceResource()
        {
        }
    }
}