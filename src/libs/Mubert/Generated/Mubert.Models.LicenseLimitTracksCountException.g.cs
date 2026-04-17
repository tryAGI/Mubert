
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license limit on the number of tracks has been exceeded.
    /// </summary>
    public sealed partial class LicenseLimitTracksCountException
    {
        /// <summary>
        /// Example: The limit of the number of tracks has been exceeded
        /// </summary>
        /// <example>The limit of the number of tracks has been exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The time-based limit type that was exceeded (e.g., daily, monthly, total).<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.LicenseLimitTracksCountExceptionTypeJsonConverter))]
        public global::Mubert.LicenseLimitTracksCountExceptionType? Type { get; set; }

        /// <summary>
        /// The current count of tracks generated or requested.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_count")]
        public int? TracksCount { get; set; }

        /// <summary>
        /// The maximum allowed track count based on the license limitations.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_count_limit")]
        public int? TracksCountLimit { get; set; }

        /// <summary>
        /// Example: LicenseLimitTracksCount
        /// </summary>
        /// <example>LicenseLimitTracksCount</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitTracksCountException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The limit of the number of tracks has been exceeded
        /// </param>
        /// <param name="type">
        /// The time-based limit type that was exceeded (e.g., daily, monthly, total).<br/>
        /// Example: monthly
        /// </param>
        /// <param name="tracksCount">
        /// The current count of tracks generated or requested.<br/>
        /// Example: 500
        /// </param>
        /// <param name="tracksCountLimit">
        /// The maximum allowed track count based on the license limitations.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="code">
        /// Example: LicenseLimitTracksCount
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseLimitTracksCountException(
            string? message,
            global::Mubert.LicenseLimitTracksCountExceptionType? type,
            int? tracksCount,
            int? tracksCountLimit,
            string? code)
        {
            this.Message = message;
            this.Type = type;
            this.TracksCount = tracksCount;
            this.TracksCountLimit = tracksCountLimit;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitTracksCountException" /> class.
        /// </summary>
        public LicenseLimitTracksCountException()
        {
        }
    }
}