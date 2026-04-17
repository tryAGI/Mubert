
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PriceLimitPublicResource
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Maximum allowed duration (in seconds) for a single track generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_track_duration")]
        public int? MaxTrackDuration { get; set; }

        /// <summary>
        /// Maximum number of tracks a user can generate concurrently
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_track_generations")]
        public int? MaxConcurrentTrackGenerations { get; set; }

        /// <summary>
        /// Overall limit on the total number of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_count_limit")]
        public int? TotalTracksCountLimit { get; set; }

        /// <summary>
        /// Overall limit on the total duration (in seconds) of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_duration_limit")]
        public int? TotalTracksDurationLimit { get; set; }

        /// <summary>
        /// Monthly limit on the number of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_count_limit")]
        public int? MonthlyTracksCountLimit { get; set; }

        /// <summary>
        /// Monthly limit on the total duration (in seconds) of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_duration_limit")]
        public int? MonthlyTracksDurationLimit { get; set; }

        /// <summary>
        /// Daily limit on the number of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_count_limit")]
        public int? DailyTracksCountLimit { get; set; }

        /// <summary>
        /// Daily limit on the total duration (in seconds) of tracks a user can generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_duration_limit")]
        public int? DailyTracksDurationLimit { get; set; }

        /// <summary>
        /// Overall limit on the total streaming duration (in seconds) for a user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_streaming_duration_limit")]
        public int? TotalStreamingDurationLimit { get; set; }

        /// <summary>
        /// Monthly limit on the streaming duration (in seconds) for a user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_streaming_duration_limit")]
        public int? MonthlyStreamingDurationLimit { get; set; }

        /// <summary>
        /// Daily limit on the streaming duration (in seconds) for a user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_streaming_duration_limit")]
        public int? DailyStreamingDurationLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceLimitPublicResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="maxTrackDuration">
        /// Maximum allowed duration (in seconds) for a single track generation
        /// </param>
        /// <param name="maxConcurrentTrackGenerations">
        /// Maximum number of tracks a user can generate concurrently
        /// </param>
        /// <param name="totalTracksCountLimit">
        /// Overall limit on the total number of tracks a user can generate
        /// </param>
        /// <param name="totalTracksDurationLimit">
        /// Overall limit on the total duration (in seconds) of tracks a user can generate
        /// </param>
        /// <param name="monthlyTracksCountLimit">
        /// Monthly limit on the number of tracks a user can generate
        /// </param>
        /// <param name="monthlyTracksDurationLimit">
        /// Monthly limit on the total duration (in seconds) of tracks a user can generate
        /// </param>
        /// <param name="dailyTracksCountLimit">
        /// Daily limit on the number of tracks a user can generate
        /// </param>
        /// <param name="dailyTracksDurationLimit">
        /// Daily limit on the total duration (in seconds) of tracks a user can generate
        /// </param>
        /// <param name="totalStreamingDurationLimit">
        /// Overall limit on the total streaming duration (in seconds) for a user
        /// </param>
        /// <param name="monthlyStreamingDurationLimit">
        /// Monthly limit on the streaming duration (in seconds) for a user
        /// </param>
        /// <param name="dailyStreamingDurationLimit">
        /// Daily limit on the streaming duration (in seconds) for a user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PriceLimitPublicResource(
            global::System.Guid? id,
            int? maxTrackDuration,
            int? maxConcurrentTrackGenerations,
            int? totalTracksCountLimit,
            int? totalTracksDurationLimit,
            int? monthlyTracksCountLimit,
            int? monthlyTracksDurationLimit,
            int? dailyTracksCountLimit,
            int? dailyTracksDurationLimit,
            int? totalStreamingDurationLimit,
            int? monthlyStreamingDurationLimit,
            int? dailyStreamingDurationLimit)
        {
            this.Id = id;
            this.MaxTrackDuration = maxTrackDuration;
            this.MaxConcurrentTrackGenerations = maxConcurrentTrackGenerations;
            this.TotalTracksCountLimit = totalTracksCountLimit;
            this.TotalTracksDurationLimit = totalTracksDurationLimit;
            this.MonthlyTracksCountLimit = monthlyTracksCountLimit;
            this.MonthlyTracksDurationLimit = monthlyTracksDurationLimit;
            this.DailyTracksCountLimit = dailyTracksCountLimit;
            this.DailyTracksDurationLimit = dailyTracksDurationLimit;
            this.TotalStreamingDurationLimit = totalStreamingDurationLimit;
            this.MonthlyStreamingDurationLimit = monthlyStreamingDurationLimit;
            this.DailyStreamingDurationLimit = dailyStreamingDurationLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceLimitPublicResource" /> class.
        /// </summary>
        public PriceLimitPublicResource()
        {
        }
    }
}