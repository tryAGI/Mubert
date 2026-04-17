
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicTracksByTrackSimilarRequest
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksByTrackSimilarRequest" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration of the track in seconds.<br/>
        /// Example: 300
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicTracksByTrackSimilarRequest(
            int duration,
            int? bitrate,
            global::Mubert.TrackFormatEnum? format,
            global::Mubert.TrackIntensityEnum? intensity,
            global::Mubert.TrackModeEnum? mode)
        {
            this.Bitrate = bitrate;
            this.Duration = duration;
            this.Format = format;
            this.Intensity = intensity;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksByTrackSimilarRequest" /> class.
        /// </summary>
        public PostPublicTracksByTrackSimilarRequest()
        {
        }
    }
}