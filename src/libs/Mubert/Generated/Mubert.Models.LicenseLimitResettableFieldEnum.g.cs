
#nullable enable

namespace Mubert
{
    /// <summary>
    /// License Limit fields that can be reset to zero
    /// </summary>
    public enum LicenseLimitResettableFieldEnum
    {
        /// <summary>
        /// 
        /// </summary>
        CustomersCount,
        /// <summary>
        /// 
        /// </summary>
        DailyStreamingDuration,
        /// <summary>
        /// 
        /// </summary>
        DailyTracksCount,
        /// <summary>
        /// 
        /// </summary>
        DailyTracksDuration,
        /// <summary>
        /// 
        /// </summary>
        MonthlyStreamingDuration,
        /// <summary>
        /// 
        /// </summary>
        MonthlyTracksCount,
        /// <summary>
        /// 
        /// </summary>
        MonthlyTracksDuration,
        /// <summary>
        /// 
        /// </summary>
        TotalStreamingDuration,
        /// <summary>
        /// 
        /// </summary>
        TotalTracksCount,
        /// <summary>
        /// 
        /// </summary>
        TotalTracksDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LicenseLimitResettableFieldEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LicenseLimitResettableFieldEnum value)
        {
            return value switch
            {
                LicenseLimitResettableFieldEnum.CustomersCount => "customers_count",
                LicenseLimitResettableFieldEnum.DailyStreamingDuration => "daily_streaming_duration",
                LicenseLimitResettableFieldEnum.DailyTracksCount => "daily_tracks_count",
                LicenseLimitResettableFieldEnum.DailyTracksDuration => "daily_tracks_duration",
                LicenseLimitResettableFieldEnum.MonthlyStreamingDuration => "monthly_streaming_duration",
                LicenseLimitResettableFieldEnum.MonthlyTracksCount => "monthly_tracks_count",
                LicenseLimitResettableFieldEnum.MonthlyTracksDuration => "monthly_tracks_duration",
                LicenseLimitResettableFieldEnum.TotalStreamingDuration => "total_streaming_duration",
                LicenseLimitResettableFieldEnum.TotalTracksCount => "total_tracks_count",
                LicenseLimitResettableFieldEnum.TotalTracksDuration => "total_tracks_duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LicenseLimitResettableFieldEnum? ToEnum(string value)
        {
            return value switch
            {
                "customers_count" => LicenseLimitResettableFieldEnum.CustomersCount,
                "daily_streaming_duration" => LicenseLimitResettableFieldEnum.DailyStreamingDuration,
                "daily_tracks_count" => LicenseLimitResettableFieldEnum.DailyTracksCount,
                "daily_tracks_duration" => LicenseLimitResettableFieldEnum.DailyTracksDuration,
                "monthly_streaming_duration" => LicenseLimitResettableFieldEnum.MonthlyStreamingDuration,
                "monthly_tracks_count" => LicenseLimitResettableFieldEnum.MonthlyTracksCount,
                "monthly_tracks_duration" => LicenseLimitResettableFieldEnum.MonthlyTracksDuration,
                "total_streaming_duration" => LicenseLimitResettableFieldEnum.TotalStreamingDuration,
                "total_tracks_count" => LicenseLimitResettableFieldEnum.TotalTracksCount,
                "total_tracks_duration" => LicenseLimitResettableFieldEnum.TotalTracksDuration,
                _ => null,
            };
        }
    }
}