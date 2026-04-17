
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicTracksRequest
    {
        /// <summary>
        /// Index of the playlist. Required if `prompt`, and `image` are not provided. If provided, `bpm` and `key` can be optionally specified.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_index")]
        public string? PlaylistIndex { get; set; }

        /// <summary>
        /// Text prompt for track creation. Required if `playlist_index`, and `image` are not provided. If provided, `bpm` and `key` are not allowed.<br/>
        /// Example: Relaxing ambient music
        /// </summary>
        /// <example>Relaxing ambient music</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Duration of the track in seconds.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Enumeration representing different track formats.<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.TrackFormatEnumJsonConverter))]
        public global::Mubert.TrackFormatEnum? Format { get; set; }

        /// <summary>
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.TrackIntensityEnumJsonConverter))]
        public global::Mubert.TrackIntensityEnum? Intensity { get; set; }

        /// <summary>
        /// Enumeration representing different modes of a track.<br/>
        /// Example: loop
        /// </summary>
        /// <example>loop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.TrackModeEnumJsonConverter))]
        public global::Mubert.TrackModeEnum? Mode { get; set; }

        /// <summary>
        /// Beats per minute (BPM). Can only be provided if `playlist_index` is specified. Not allowed if `prompt`, or `image` are used.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// Key-Scale for a track.<br/>
        /// Example: C#
        /// </summary>
        /// <example>C#</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.TrackKeyScaleEnumJsonConverter))]
        public global::Mubert.TrackKeyScaleEnum? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksRequest" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration of the track in seconds.<br/>
        /// Example: 300
        /// </param>
        /// <param name="playlistIndex">
        /// Index of the playlist. Required if `prompt`, and `image` are not provided. If provided, `bpm` and `key` can be optionally specified.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="prompt">
        /// Text prompt for track creation. Required if `playlist_index`, and `image` are not provided. If provided, `bpm` and `key` are not allowed.<br/>
        /// Example: Relaxing ambient music
        /// </param>
        /// <param name="image">
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
        /// </param>
        /// <param name="imagename">
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
        /// </param>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="format">
        /// Enumeration representing different track formats.<br/>
        /// Example: mp3
        /// </param>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
        /// <param name="mode">
        /// Enumeration representing different modes of a track.<br/>
        /// Example: loop
        /// </param>
        /// <param name="bpm">
        /// Beats per minute (BPM). Can only be provided if `playlist_index` is specified. Not allowed if `prompt`, or `image` are used.<br/>
        /// Example: 120
        /// </param>
        /// <param name="key">
        /// Key-Scale for a track.<br/>
        /// Example: C#
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicTracksRequest(
            int duration,
            string? playlistIndex,
            string? prompt,
            byte[]? image,
            string? imagename,
            int? bitrate,
            global::Mubert.TrackFormatEnum? format,
            global::Mubert.TrackIntensityEnum? intensity,
            global::Mubert.TrackModeEnum? mode,
            int? bpm,
            global::Mubert.TrackKeyScaleEnum? key)
        {
            this.PlaylistIndex = playlistIndex;
            this.Prompt = prompt;
            this.Image = image;
            this.Imagename = imagename;
            this.Bitrate = bitrate;
            this.Duration = duration;
            this.Format = format;
            this.Intensity = intensity;
            this.Mode = mode;
            this.Bpm = bpm;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksRequest" /> class.
        /// </summary>
        public PostPublicTracksRequest()
        {
        }
    }
}