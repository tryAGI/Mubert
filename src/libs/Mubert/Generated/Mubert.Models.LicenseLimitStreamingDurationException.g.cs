
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license limit on streaming duration has been exceeded.
    /// </summary>
    public sealed partial class LicenseLimitStreamingDurationException
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.LicenseLimitStreamingDurationExceptionTypeJsonConverter))]
        public global::Mubert.LicenseLimitStreamingDurationExceptionType? Type { get; set; }

        /// <summary>
        /// Current total duration of streaming in seconds.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_duration")]
        public int? StreamingDuration { get; set; }

        /// <summary>
        /// Allowed duration limit for streaming in seconds based on license.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_duration_limit")]
        public int? StreamingDurationLimit { get; set; }

        /// <summary>
        /// Example: LicenseLimitStreamingDuration
        /// </summary>
        /// <example>LicenseLimitStreamingDuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitStreamingDurationException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Track duration limit exceeded
        /// </param>
        /// <param name="type">
        /// The time-based duration limit type that was exceeded (e.g., daily, monthly, total).<br/>
        /// Example: monthly
        /// </param>
        /// <param name="streamingDuration">
        /// Current total duration of streaming in seconds.<br/>
        /// Example: 3600
        /// </param>
        /// <param name="streamingDurationLimit">
        /// Allowed duration limit for streaming in seconds based on license.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="code">
        /// Example: LicenseLimitStreamingDuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseLimitStreamingDurationException(
            string? message,
            global::Mubert.LicenseLimitStreamingDurationExceptionType? type,
            int? streamingDuration,
            int? streamingDurationLimit,
            string? code)
        {
            this.Message = message;
            this.Type = type;
            this.StreamingDuration = streamingDuration;
            this.StreamingDurationLimit = streamingDurationLimit;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitStreamingDurationException" /> class.
        /// </summary>
        public LicenseLimitStreamingDurationException()
        {
        }
    }
}