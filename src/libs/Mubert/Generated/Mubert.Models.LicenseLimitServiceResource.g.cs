
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LicenseLimitServiceResource
    {
        /// <summary>
        /// License Limit ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Associated License ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_id")]
        public global::System.Guid? LicenseId { get; set; }

        /// <summary>
        /// Max track duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_track_duration")]
        public int? MaxTrackDuration { get; set; }

        /// <summary>
        /// Max concurrent track generations allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_track_generations")]
        public int? MaxConcurrentTrackGenerations { get; set; }

        /// <summary>
        /// Total number of tracks generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_count")]
        public int? TotalTracksCount { get; set; }

        /// <summary>
        /// Limit on total number of tracks that can be generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_count_limit")]
        public int? TotalTracksCountLimit { get; set; }

        /// <summary>
        /// Total duration of generated tracks (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_duration")]
        public int? TotalTracksDuration { get; set; }

        /// <summary>
        /// Limit on the total duration of tracks (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tracks_duration_limit")]
        public int? TotalTracksDurationLimit { get; set; }

        /// <summary>
        /// Tracks generated this month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_count")]
        public int? MonthlyTracksCount { get; set; }

        /// <summary>
        /// Limit on tracks that can be generated monthly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_count_limit")]
        public int? MonthlyTracksCountLimit { get; set; }

        /// <summary>
        /// Total duration of tracks generated this month (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_duration")]
        public int? MonthlyTracksDuration { get; set; }

        /// <summary>
        /// Limit on the total track duration per month (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_tracks_duration_limit")]
        public int? MonthlyTracksDurationLimit { get; set; }

        /// <summary>
        /// Tracks generated today
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_count")]
        public int? DailyTracksCount { get; set; }

        /// <summary>
        /// Limit on tracks that can be generated daily
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_count_limit")]
        public int? DailyTracksCountLimit { get; set; }

        /// <summary>
        /// Total duration of tracks generated today (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_tracks_duration")]
        public int? DailyTracksDuration { get; set; }

        /// <summary>
        /// Limit on the total track duration per day (in seconds)
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
        /// Number of customers utilizing this license limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customers_count")]
        public int? CustomersCount { get; set; }

        /// <summary>
        /// Maximum number of customers allowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customers_count_limit")]
        public int? CustomersCountLimit { get; set; }

        /// <summary>
        /// Max concurrent track generations per customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_max_concurrent_track_generations")]
        public int? CustomerMaxConcurrentTrackGenerations { get; set; }

        /// <summary>
        /// Limit on total number of tracks per customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_total_tracks_count_limit")]
        public int? CustomerTotalTracksCountLimit { get; set; }

        /// <summary>
        /// Limit on total track duration per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_total_tracks_duration_limit")]
        public int? CustomerTotalTracksDurationLimit { get; set; }

        /// <summary>
        /// Monthly track count limit per customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_monthly_tracks_count_limit")]
        public int? CustomerMonthlyTracksCountLimit { get; set; }

        /// <summary>
        /// Monthly track duration limit per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_monthly_tracks_duration_limit")]
        public int? CustomerMonthlyTracksDurationLimit { get; set; }

        /// <summary>
        /// Daily track count limit per customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_daily_tracks_count_limit")]
        public int? CustomerDailyTracksCountLimit { get; set; }

        /// <summary>
        /// Daily track duration limit per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_daily_tracks_duration_limit")]
        public int? CustomerDailyTracksDurationLimit { get; set; }

        /// <summary>
        /// Limit on total streaming duration per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_total_streaming_duration_limit")]
        public int? CustomerTotalStreamingDurationLimit { get; set; }

        /// <summary>
        /// Limit on monthly streaming duration per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_monthly_streaming_duration_limit")]
        public int? CustomerMonthlyStreamingDurationLimit { get; set; }

        /// <summary>
        /// Limit on daily streaming duration per customer (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_daily_streaming_duration_limit")]
        public int? CustomerDailyStreamingDurationLimit { get; set; }

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
        /// Initializes a new instance of the <see cref="LicenseLimitServiceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// License Limit ID
        /// </param>
        /// <param name="licenseId">
        /// Associated License ID
        /// </param>
        /// <param name="maxTrackDuration">
        /// Max track duration
        /// </param>
        /// <param name="maxConcurrentTrackGenerations">
        /// Max concurrent track generations allowed
        /// </param>
        /// <param name="totalTracksCount">
        /// Total number of tracks generated
        /// </param>
        /// <param name="totalTracksCountLimit">
        /// Limit on total number of tracks that can be generated
        /// </param>
        /// <param name="totalTracksDuration">
        /// Total duration of generated tracks (in seconds)
        /// </param>
        /// <param name="totalTracksDurationLimit">
        /// Limit on the total duration of tracks (in seconds)
        /// </param>
        /// <param name="monthlyTracksCount">
        /// Tracks generated this month
        /// </param>
        /// <param name="monthlyTracksCountLimit">
        /// Limit on tracks that can be generated monthly
        /// </param>
        /// <param name="monthlyTracksDuration">
        /// Total duration of tracks generated this month (in seconds)
        /// </param>
        /// <param name="monthlyTracksDurationLimit">
        /// Limit on the total track duration per month (in seconds)
        /// </param>
        /// <param name="dailyTracksCount">
        /// Tracks generated today
        /// </param>
        /// <param name="dailyTracksCountLimit">
        /// Limit on tracks that can be generated daily
        /// </param>
        /// <param name="dailyTracksDuration">
        /// Total duration of tracks generated today (in seconds)
        /// </param>
        /// <param name="dailyTracksDurationLimit">
        /// Limit on the total track duration per day (in seconds)
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
        /// <param name="customersCount">
        /// Number of customers utilizing this license limit
        /// </param>
        /// <param name="customersCountLimit">
        /// Maximum number of customers allowed
        /// </param>
        /// <param name="customerMaxConcurrentTrackGenerations">
        /// Max concurrent track generations per customer
        /// </param>
        /// <param name="customerTotalTracksCountLimit">
        /// Limit on total number of tracks per customer
        /// </param>
        /// <param name="customerTotalTracksDurationLimit">
        /// Limit on total track duration per customer (in seconds)
        /// </param>
        /// <param name="customerMonthlyTracksCountLimit">
        /// Monthly track count limit per customer
        /// </param>
        /// <param name="customerMonthlyTracksDurationLimit">
        /// Monthly track duration limit per customer (in seconds)
        /// </param>
        /// <param name="customerDailyTracksCountLimit">
        /// Daily track count limit per customer
        /// </param>
        /// <param name="customerDailyTracksDurationLimit">
        /// Daily track duration limit per customer (in seconds)
        /// </param>
        /// <param name="customerTotalStreamingDurationLimit">
        /// Limit on total streaming duration per customer (in seconds)
        /// </param>
        /// <param name="customerMonthlyStreamingDurationLimit">
        /// Limit on monthly streaming duration per customer (in seconds)
        /// </param>
        /// <param name="customerDailyStreamingDurationLimit">
        /// Limit on daily streaming duration per customer (in seconds)
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
        public LicenseLimitServiceResource(
            global::System.Guid? id,
            global::System.Guid? licenseId,
            int? maxTrackDuration,
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
            int? customersCount,
            int? customersCountLimit,
            int? customerMaxConcurrentTrackGenerations,
            int? customerTotalTracksCountLimit,
            int? customerTotalTracksDurationLimit,
            int? customerMonthlyTracksCountLimit,
            int? customerMonthlyTracksDurationLimit,
            int? customerDailyTracksCountLimit,
            int? customerDailyTracksDurationLimit,
            int? customerTotalStreamingDurationLimit,
            int? customerMonthlyStreamingDurationLimit,
            int? customerDailyStreamingDurationLimit,
            global::System.DateTime? dailyResetAt,
            global::System.DateTime? monthlyResetAt)
        {
            this.Id = id;
            this.LicenseId = licenseId;
            this.MaxTrackDuration = maxTrackDuration;
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
            this.CustomersCount = customersCount;
            this.CustomersCountLimit = customersCountLimit;
            this.CustomerMaxConcurrentTrackGenerations = customerMaxConcurrentTrackGenerations;
            this.CustomerTotalTracksCountLimit = customerTotalTracksCountLimit;
            this.CustomerTotalTracksDurationLimit = customerTotalTracksDurationLimit;
            this.CustomerMonthlyTracksCountLimit = customerMonthlyTracksCountLimit;
            this.CustomerMonthlyTracksDurationLimit = customerMonthlyTracksDurationLimit;
            this.CustomerDailyTracksCountLimit = customerDailyTracksCountLimit;
            this.CustomerDailyTracksDurationLimit = customerDailyTracksDurationLimit;
            this.CustomerTotalStreamingDurationLimit = customerTotalStreamingDurationLimit;
            this.CustomerMonthlyStreamingDurationLimit = customerMonthlyStreamingDurationLimit;
            this.CustomerDailyStreamingDurationLimit = customerDailyStreamingDurationLimit;
            this.DailyResetAt = dailyResetAt;
            this.MonthlyResetAt = monthlyResetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLimitServiceResource" /> class.
        /// </summary>
        public LicenseLimitServiceResource()
        {
        }
    }
}