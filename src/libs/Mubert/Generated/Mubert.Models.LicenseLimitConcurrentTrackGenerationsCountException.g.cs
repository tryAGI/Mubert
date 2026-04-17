
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Response indicating that the license limit on concurrent track generations has been exceeded.
    /// </summary>
    public sealed partial class LicenseLimitConcurrentTrackGenerationsCountException
    {
        /// <summary>
        /// Example: The limit of concurrent track generations has been exceeded
        /// </summary>
        /// <example>The limit of concurrent track generations has been exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_track_generations")]
        public int? ConcurrentTrackGenerations { get; set; }

        /// <summary>
        /// Example: LicenseLimitConcurrentTrackGenerationsCount
        /// </summary>
        /// <example>LicenseLimitConcurrentTrackGenerationsCount</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitConcurrentTrackGenerationsCountException" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: The limit of concurrent track generations has been exceeded
        /// </param>
        /// <param name="concurrentTrackGenerations">
        /// Example: 5
        /// </param>
        /// <param name="code">
        /// Example: LicenseLimitConcurrentTrackGenerationsCount
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicenseLimitConcurrentTrackGenerationsCountException(
            string? message,
            int? concurrentTrackGenerations,
            string? code)
        {
            this.Message = message;
            this.ConcurrentTrackGenerations = concurrentTrackGenerations;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitConcurrentTrackGenerationsCountException" /> class.
        /// </summary>
        public LicenseLimitConcurrentTrackGenerationsCountException()
        {
        }
    }
}