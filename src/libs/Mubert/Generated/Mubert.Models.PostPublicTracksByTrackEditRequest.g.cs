
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicTracksByTrackEditRequest
    {
        /// <summary>
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </summary>
        /// <example>320</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// The duration of the track in seconds. Must be between 5 and 3600.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

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
        /// Replace stems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_stems")]
        public global::System.Collections.Generic.IList<global::Mubert.StemEnum>? ReplaceStems { get; set; }

        /// <summary>
        /// Delete stems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_stems")]
        public global::System.Collections.Generic.IList<global::Mubert.StemEnum>? DeleteStems { get; set; }

        /// <summary>
        /// Replace instruments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_instruments")]
        public global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? ReplaceInstruments { get; set; }

        /// <summary>
        /// Delete instruments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_instruments")]
        public global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? DeleteInstruments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksByTrackEditRequest" /> class.
        /// </summary>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="duration">
        /// The duration of the track in seconds. Must be between 5 and 3600.<br/>
        /// Example: 300
        /// </param>
        /// <param name="format">
        /// Enumeration representing different track formats.<br/>
        /// Example: mp3
        /// </param>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
        /// <param name="replaceStems">
        /// Replace stems
        /// </param>
        /// <param name="deleteStems">
        /// Delete stems
        /// </param>
        /// <param name="replaceInstruments">
        /// Replace instruments
        /// </param>
        /// <param name="deleteInstruments">
        /// Delete instruments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicTracksByTrackEditRequest(
            int? bitrate,
            int? duration,
            global::Mubert.TrackFormatEnum? format,
            global::Mubert.TrackIntensityEnum? intensity,
            global::System.Collections.Generic.IList<global::Mubert.StemEnum>? replaceStems,
            global::System.Collections.Generic.IList<global::Mubert.StemEnum>? deleteStems,
            global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? replaceInstruments,
            global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? deleteInstruments)
        {
            this.Bitrate = bitrate;
            this.Duration = duration;
            this.Format = format;
            this.Intensity = intensity;
            this.ReplaceStems = replaceStems;
            this.DeleteStems = deleteStems;
            this.ReplaceInstruments = replaceInstruments;
            this.DeleteInstruments = deleteInstruments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicTracksByTrackEditRequest" /> class.
        /// </summary>
        public PostPublicTracksByTrackEditRequest()
        {
        }
    }
}