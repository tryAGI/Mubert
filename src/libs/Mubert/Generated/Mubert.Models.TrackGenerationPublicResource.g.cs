
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackGenerationPublicResource
    {
        /// <summary>
        /// Session ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// track format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Bitrate value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// track status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Generation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public global::System.DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// Expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGenerationPublicResource" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Session ID
        /// </param>
        /// <param name="format">
        /// track format
        /// </param>
        /// <param name="bitrate">
        /// Bitrate value
        /// </param>
        /// <param name="status">
        /// track status
        /// </param>
        /// <param name="generatedAt">
        /// Generation timestamp
        /// </param>
        /// <param name="expiredAt">
        /// Expiration timestamp
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackGenerationPublicResource(
            string? sessionId,
            string? format,
            int? bitrate,
            string? status,
            global::System.DateTime? generatedAt,
            global::System.DateTime? expiredAt,
            global::System.DateTime? createdAt)
        {
            this.SessionId = sessionId;
            this.Format = format;
            this.Bitrate = bitrate;
            this.Status = status;
            this.GeneratedAt = generatedAt;
            this.ExpiredAt = expiredAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackGenerationPublicResource" /> class.
        /// </summary>
        public TrackGenerationPublicResource()
        {
        }
    }
}