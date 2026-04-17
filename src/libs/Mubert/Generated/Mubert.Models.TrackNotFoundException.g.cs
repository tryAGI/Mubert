
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the requested track was not found.
    /// </summary>
    public sealed partial class TrackNotFoundException
    {
        /// <summary>
        /// Description of the error message, including the missing track session ID.<br/>
        /// Example: Track {sessionId} not found
        /// </summary>
        /// <example>Track {sessionId} not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The session ID of the requested track.<br/>
        /// Example: abc123-session-id
        /// </summary>
        /// <example>abc123-session-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Unique code identifying the track-not-found error.<br/>
        /// Example: TrackNotFound
        /// </summary>
        /// <example>TrackNotFound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackNotFoundException" /> class.
        /// </summary>
        /// <param name="message">
        /// Description of the error message, including the missing track session ID.<br/>
        /// Example: Track {sessionId} not found
        /// </param>
        /// <param name="sessionId">
        /// The session ID of the requested track.<br/>
        /// Example: abc123-session-id
        /// </param>
        /// <param name="code">
        /// Unique code identifying the track-not-found error.<br/>
        /// Example: TrackNotFound
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackNotFoundException(
            string? message,
            string? sessionId,
            string? code)
        {
            this.Message = message;
            this.SessionId = sessionId;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackNotFoundException" /> class.
        /// </summary>
        public TrackNotFoundException()
        {
        }
    }
}