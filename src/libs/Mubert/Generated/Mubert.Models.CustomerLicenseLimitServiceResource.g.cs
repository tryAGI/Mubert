
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerLicenseLimitServiceResource
    {
        /// <summary>
        /// Customer license limit ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Customer ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        public global::System.Guid? CustomerId { get; set; }

        /// <summary>
        /// License ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_id")]
        public global::System.Guid? LicenseId { get; set; }

        /// <summary>
        /// Maximum number of concurrent track generations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_track_generations")]
        public int? MaxConcurrentTrackGenerations { get; set; }

        /// <summary>
        /// Total number of tracks generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_count")]
        public int? TotalTracksCount { get; set; }

        /// <summary>
        /// Total track count limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_count_limit")]
        public int? TotalTracksCountLimit { get; set; }

        /// <summary>
        /// Total duration of tracks generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_duration")]
        public int? TotalTracksDuration { get; set; }

        /// <summary>
        /// Total track duration limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_duration_limit")]
        public int? TotalTracksDurationLimit { get; set; }

        /// <summary>
        /// Tracks generated this month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_count")]
        public int? MonthlyTracksCount { get; set; }

        /// <summary>
        /// Monthly track count limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_count_limit")]
        public int? MonthlyTracksCountLimit { get; set; }

        /// <summary>
        /// Monthly track duration generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_duration")]
        public int? MonthlyTracksDuration { get; set; }

        /// <summary>
        /// Monthly track duration limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_duration_limit")]
        public int? MonthlyTracksDurationLimit { get; set; }

        /// <summary>
        /// Tracks generated today
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_count")]
        public int? DailyTracksCount { get; set; }

        /// <summary>
        /// Daily track count limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_count_limit")]
        public int? DailyTracksCountLimit { get; set; }

        /// <summary>
        /// Daily track duration generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_duration")]
        public int? DailyTracksDuration { get; set; }

        /// <summary>
        /// Daily track duration limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_duration_limit")]
        public int? DailyTracksDurationLimit { get; set; }

        /// <summary>
        /// Total streaming duration (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_streaming_duration")]
        public int? TotalStreamingDuration { get; set; }

        /// <summary>
        /// Limit on total streaming duration (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_streaming_duration_limit")]
        public int? TotalStreamingDurationLimit { get; set; }

        /// <summary>
        /// Streaming duration this month (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_streaming_duration")]
        public int? MonthlyStreamingDuration { get; set; }

        /// <summary>
        /// Limit on monthly streaming duration (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_streaming_duration_limit")]
        public int? MonthlyStreamingDurationLimit { get; set; }

        /// <summary>
        /// Streaming duration today (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_streaming_duration")]
        public int? DailyStreamingDuration { get; set; }

        /// <summary>
        /// Limit on daily streaming duration (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_streaming_duration_limit")]
        public int? DailyStreamingDurationLimit { get; set; }

        /// <summary>
        /// Last reset of daily limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_reset_at")]
        public global::System.DateTime? DailyResetAt { get; set; }

        /// <summary>
        /// Last reset of monthly limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_reset_at")]
        public global::System.DateTime? MonthlyResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLicenseLimitServiceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Customer license limit ID
        /// </param>
        /// <param name="customerId">
        /// Customer ID
        /// </param>
        /// <param name="licenseId">
        /// License ID
        /// </param>
        /// <param name="maxConcurrentTrackGenerations">
        /// Maximum number of concurrent track generations
        /// </param>
        /// <param name="totalTracksCount">
        /// Total number of tracks generated
        /// </param>
        /// <param name="totalTracksCountLimit">
        /// Total track count limit
        /// </param>
        /// <param name="totalTracksDuration">
        /// Total duration of tracks generated
        /// </param>
        /// <param name="totalTracksDurationLimit">
        /// Total track duration limit
        /// </param>
        /// <param name="monthlyTracksCount">
        /// Tracks generated this month
        /// </param>
        /// <param name="monthlyTracksCountLimit">
        /// Monthly track count limit
        /// </param>
        /// <param name="monthlyTracksDuration">
        /// Monthly track duration generated
        /// </param>
        /// <param name="monthlyTracksDurationLimit">
        /// Monthly track duration limit
        /// </param>
        /// <param name="dailyTracksCount">
        /// Tracks generated today
        /// </param>
        /// <param name="dailyTracksCountLimit">
        /// Daily track count limit
        /// </param>
        /// <param name="dailyTracksDuration">
        /// Daily track duration generated
        /// </param>
        /// <param name="dailyTracksDurationLimit">
        /// Daily track duration limit
        /// </param>
        /// <param name="totalStreamingDuration">
        /// Total streaming duration (in seconds)
        /// </param>
        /// <param name="totalStreamingDurationLimit">
        /// Limit on total streaming duration (in seconds)
        /// </param>
        /// <param name="monthlyStreamingDuration">
        /// Streaming duration this month (in seconds)
        /// </param>
        /// <param name="monthlyStreamingDurationLimit">
        /// Limit on monthly streaming duration (in seconds)
        /// </param>
        /// <param name="dailyStreamingDuration">
        /// Streaming duration today (in seconds)
        /// </param>
        /// <param name="dailyStreamingDurationLimit">
        /// Limit on daily streaming duration (in seconds)
        /// </param>
        /// <param name="dailyResetAt">
        /// Last reset of daily limit
        /// </param>
        /// <param name="monthlyResetAt">
        /// Last reset of monthly limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerLicenseLimitServiceResource(
            global::System.Guid? id,
            global::System.Guid? customerId,
            global::System.Guid? licenseId,
            int? maxConcurrentTrackGenerations,
            int? totalTracksCount,
            int? totalTracksCountLimit,
            int? totalTracksDuration,
            int? totalTracksDurationLimit,
            int? monthlyTracksCount,
            int? monthlyTracksCountLimit,
            int? monthlyTracksDuration,
            int? monthlyTracksDurationLimit,
            int? dailyTracksCount,
            int? dailyTracksCountLimit,
            int? dailyTracksDuration,
            int? dailyTracksDurationLimit,
            int? totalStreamingDuration,
            int? totalStreamingDurationLimit,
            int? monthlyStreamingDuration,
            int? monthlyStreamingDurationLimit,
            int? dailyStreamingDuration,
            int? dailyStreamingDurationLimit,
            global::System.DateTime? dailyResetAt,
            global::System.DateTime? monthlyResetAt)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.LicenseId = licenseId;
            this.MaxConcurrentTrackGenerations = maxConcurrentTrackGenerations;
            this.TotalTracksCount = totalTracksCount;
            this.TotalTracksCountLimit = totalTracksCountLimit;
            this.TotalTracksDuration = totalTracksDuration;
            this.TotalTracksDurationLimit = totalTracksDurationLimit;
            this.MonthlyTracksCount = monthlyTracksCount;
            this.MonthlyTracksCountLimit = monthlyTracksCountLimit;
            this.MonthlyTracksDuration = monthlyTracksDuration;
            this.MonthlyTracksDurationLimit = monthlyTracksDurationLimit;
            this.DailyTracksCount = dailyTracksCount;
            this.DailyTracksCountLimit = dailyTracksCountLimit;
            this.DailyTracksDuration = dailyTracksDuration;
            this.DailyTracksDurationLimit = dailyTracksDurationLimit;
            this.TotalStreamingDuration = totalStreamingDuration;
            this.TotalStreamingDurationLimit = totalStreamingDurationLimit;
            this.MonthlyStreamingDuration = monthlyStreamingDuration;
            this.MonthlyStreamingDurationLimit = monthlyStreamingDurationLimit;
            this.DailyStreamingDuration = dailyStreamingDuration;
            this.DailyStreamingDurationLimit = dailyStreamingDurationLimit;
            this.DailyResetAt = dailyResetAt;
            this.MonthlyResetAt = monthlyResetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerLicenseLimitServiceResource" /> class.
        /// </summary>
        public CustomerLicenseLimitServiceResource()
        {
        }
    }
}