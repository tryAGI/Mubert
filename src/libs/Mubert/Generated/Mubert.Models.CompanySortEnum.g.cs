
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Available sort fields for companies
    /// </summary>
    public enum CompanySortEnum
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        CustomersCount,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        LicensesActiveCount,
        /// <summary>
        /// 
        /// </summary>
        LicensesTotalCount,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionsActiveCount,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionsTotalCount,
        /// <summary>
        /// 
        /// </summary>
        TotalPaid,
        /// <summary>
        /// 
        /// </summary>
        TracksCount,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompanySortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompanySortEnum value)
        {
            return value switch
            {
                CompanySortEnum.CreatedAt => "created_at",
                CompanySortEnum.CustomersCount => "customers_count",
                CompanySortEnum.Email => "email",
                CompanySortEnum.LicensesActiveCount => "licenses_active_count",
                CompanySortEnum.LicensesTotalCount => "licenses_total_count",
                CompanySortEnum.Name => "name",
                CompanySortEnum.Status => "status",
                CompanySortEnum.SubscriptionsActiveCount => "subscriptions_active_count",
                CompanySortEnum.SubscriptionsTotalCount => "subscriptions_total_count",
                CompanySortEnum.TotalPaid => "total_paid",
                CompanySortEnum.TracksCount => "tracks_count",
                CompanySortEnum.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompanySortEnum? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => CompanySortEnum.CreatedAt,
                "customers_count" => CompanySortEnum.CustomersCount,
                "email" => CompanySortEnum.Email,
                "licenses_active_count" => CompanySortEnum.LicensesActiveCount,
                "licenses_total_count" => CompanySortEnum.LicensesTotalCount,
                "name" => CompanySortEnum.Name,
                "status" => CompanySortEnum.Status,
                "subscriptions_active_count" => CompanySortEnum.SubscriptionsActiveCount,
                "subscriptions_total_count" => CompanySortEnum.SubscriptionsTotalCount,
                "total_paid" => CompanySortEnum.TotalPaid,
                "tracks_count" => CompanySortEnum.TracksCount,
                "updated_at" => CompanySortEnum.UpdatedAt,
                _ => null,
            };
        }
    }
}