
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license limit on track duration has been exceeded.
    /// </summary>
    public sealed partial class LicenseLimitTracksDurationException
    {
        /// <summary>
        /// Example: Track duration limit exceeded
        /// </summary>
        /// <example>Track duration limit exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The time-based duration limit type that was exceeded (e.g., daily, monthly, total).<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.LicenseLimitTracksDurationExceptionTypeJsonConverter))]
        public global::Mubert.LicenseLimitTracksDurationExceptionType? Type { get; set; }

        /// <summary>
        /// Current total duration of tracks in seconds.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_duration")]
        public int? TracksDuration { get; set; }

        /// <summary>
        /// Allowed duration limit for tracks in seconds based on license.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_duration_limit")]
        public int? TracksDurationLimit { get; set; }

        /// <summary>
        /// Duration of the track that caused the limit to be exceeded.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_duration")]
        public int? TrackDuration { get; set; }

        /// <summary>
        /// Example: LicenseLimitTracksDuration
        /// </summary>
        /// <example>LicenseLimitTracksDuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitTracksDurationException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Track duration limit exceeded
        /// </param>
        /// <param name="type">
        /// The time-based duration limit type that was exceeded (e.g., daily, monthly, total).<br/>
        /// Example: monthly
        /// </param>
        /// <param name="tracksDuration">
        /// Current total duration of tracks in seconds.<br/>
        /// Example: 3600
        /// </param>
        /// <param name="tracksDurationLimit">
        /// Allowed duration limit for tracks in seconds based on license.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="trackDuration">
        /// Duration of the track that caused the limit to be exceeded.<br/>
        /// Example: 300
        /// </param>
        /// <param name="code">
        /// Example: LicenseLimitTracksDuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseLimitTracksDurationException(
            string? message,
            global::Mubert.LicenseLimitTracksDurationExceptionType? type,
            int? tracksDuration,
            int? tracksDurationLimit,
            int? trackDuration,
            string? code)
        {
            this.Message = message;
            this.Type = type;
            this.TracksDuration = tracksDuration;
            this.TracksDurationLimit = tracksDurationLimit;
            this.TrackDuration = trackDuration;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitTracksDurationException" /> class.
        /// </summary>
        public LicenseLimitTracksDurationException()
        {
        }
    }
}