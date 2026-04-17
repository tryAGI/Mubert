
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackServiceResource
    {
        /// <summary>
        /// ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Playlist index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_index")]
        public string? PlaylistIndex { get; set; }

        /// <summary>
        /// Prompt text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Intensity level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// Mode of the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Key of the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Beats per minute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackServiceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// ID
        /// </param>
        /// <param name="sessionId">
        /// Session ID
        /// </param>
        /// <param name="playlistIndex">
        /// Playlist index
        /// </param>
        /// <param name="prompt">
        /// Prompt text
        /// </param>
        /// <param name="duration">
        /// Duration in seconds
        /// </param>
        /// <param name="intensity">
        /// Intensity level
        /// </param>
        /// <param name="mode">
        /// Mode of the track
        /// </param>
        /// <param name="key">
        /// Key of the track
        /// </param>
        /// <param name="bpm">
        /// Beats per minute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackServiceResource(
            global::System.Guid? id,
            string? sessionId,
            string? playlistIndex,
            string? prompt,
            int? duration,
            int? intensity,
            string? mode,
            string? key,
            int? bpm)
        {
            this.Id = id;
            this.SessionId = sessionId;
            this.PlaylistIndex = playlistIndex;
            this.Prompt = prompt;
            this.Duration = duration;
            this.Intensity = intensity;
            this.Mode = mode;
            this.Key = key;
            this.Bpm = bpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackServiceResource" /> class.
        /// </summary>
        public TrackServiceResource()
        {
        }
    }
}