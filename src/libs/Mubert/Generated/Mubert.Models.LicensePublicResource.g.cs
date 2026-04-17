
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LicensePublicResource
    {
        /// <summary>
        /// License ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Company ID associated with the license
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public global::System.Guid? CompanyId { get; set; }

        /// <summary>
        /// License type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// License status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Webhook URL for the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Whether the webhook is enabled for the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_enabled")]
        public bool? WebhookEnabled { get; set; }

        /// <summary>
        /// Time after which generated tracks expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_expiration_time")]
        public int? TrackExpirationTime { get; set; }

        /// <summary>
        /// Allow all features flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_features")]
        public bool? AllowAllFeatures { get; set; }

        /// <summary>
        /// Available features for the license
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<global::Mubert.FeatureEnum>? Features { get; set; }

        /// <summary>
        /// Allow all bitrates flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_bitrates")]
        public bool? AllowAllBitrates { get; set; }

        /// <summary>
        /// Default bitrate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_bitrate")]
        public int? DefaultBitrate { get; set; }

        /// <summary>
        /// Available bitrates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrates")]
        public global::System.Collections.Generic.IList<int>? Bitrates { get; set; }

        /// <summary>
        /// Allow all intensities flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_intensities")]
        public bool? AllowAllIntensities { get; set; }

        /// <summary>
        /// Default intensity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_intensity")]
        public string? DefaultIntensity { get; set; }

        /// <summary>
        /// Available intensities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensities")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackIntensityEnum>? Intensities { get; set; }

        /// <summary>
        /// Allow all formats flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_formats")]
        public bool? AllowAllFormats { get; set; }

        /// <summary>
        /// Default track format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_format")]
        public string? DefaultFormat { get; set; }

        /// <summary>
        /// Available formats for tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_formats")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackFormatEnum>? TrackFormats { get; set; }

        /// <summary>
        /// Allow all modes flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_modes")]
        public bool? AllowAllModes { get; set; }

        /// <summary>
        /// Default track mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_mode")]
        public string? DefaultMode { get; set; }

        /// <summary>
        /// Available modes for tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_modes")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackModeEnum>? TrackModes { get; set; }

        /// <summary>
        /// License expiration date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// Timestamp when the license was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Associated License Limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_limits")]
        public global::Mubert.LicenseLimitPublicResource? LicenseLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublicResource" /> class.
        /// </summary>
        /// <param name="id">
        /// License ID
        /// </param>
        /// <param name="companyId">
        /// Company ID associated with the license
        /// </param>
        /// <param name="type">
        /// License type
        /// </param>
        /// <param name="status">
        /// License status
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL for the company
        /// </param>
        /// <param name="webhookEnabled">
        /// Whether the webhook is enabled for the company
        /// </param>
        /// <param name="trackExpirationTime">
        /// Time after which generated tracks expire
        /// </param>
        /// <param name="allowAllFeatures">
        /// Allow all features flag
        /// </param>
        /// <param name="features">
        /// Available features for the license
        /// </param>
        /// <param name="allowAllBitrates">
        /// Allow all bitrates flag
        /// </param>
        /// <param name="defaultBitrate">
        /// Default bitrate
        /// </param>
        /// <param name="bitrates">
        /// Available bitrates
        /// </param>
        /// <param name="allowAllIntensities">
        /// Allow all intensities flag
        /// </param>
        /// <param name="defaultIntensity">
        /// Default intensity
        /// </param>
        /// <param name="intensities">
        /// Available intensities
        /// </param>
        /// <param name="allowAllFormats">
        /// Allow all formats flag
        /// </param>
        /// <param name="defaultFormat">
        /// Default track format
        /// </param>
        /// <param name="trackFormats">
        /// Available formats for tracks
        /// </param>
        /// <param name="allowAllModes">
        /// Allow all modes flag
        /// </param>
        /// <param name="defaultMode">
        /// Default track mode
        /// </param>
        /// <param name="trackModes">
        /// Available modes for tracks
        /// </param>
        /// <param name="expiredAt">
        /// License expiration date
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the license was created
        /// </param>
        /// <param name="licenseLimits">
        /// Associated License Limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LicensePublicResource(
            global::System.Guid? id,
            global::System.Guid? companyId,
            string? type,
            string? status,
            string? webhookUrl,
            bool? webhookEnabled,
            int? trackExpirationTime,
            bool? allowAllFeatures,
            global::System.Collections.Generic.IList<global::Mubert.FeatureEnum>? features,
            bool? allowAllBitrates,
            int? defaultBitrate,
            global::System.Collections.Generic.IList<int>? bitrates,
            bool? allowAllIntensities,
            string? defaultIntensity,
            global::System.Collections.Generic.IList<global::Mubert.TrackIntensityEnum>? intensities,
            bool? allowAllFormats,
            string? defaultFormat,
            global::System.Collections.Generic.IList<global::Mubert.TrackFormatEnum>? trackFormats,
            bool? allowAllModes,
            string? defaultMode,
            global::System.Collections.Generic.IList<global::Mubert.TrackModeEnum>? trackModes,
            global::System.DateTime? expiredAt,
            global::System.DateTime? createdAt,
            global::Mubert.LicenseLimitPublicResource? licenseLimits)
        {
            this.Id = id;
            this.CompanyId = companyId;
            this.Type = type;
            this.Status = status;
            this.WebhookUrl = webhookUrl;
            this.WebhookEnabled = webhookEnabled;
            this.TrackExpirationTime = trackExpirationTime;
            this.AllowAllFeatures = allowAllFeatures;
            this.Features = features;
            this.AllowAllBitrates = allowAllBitrates;
            this.DefaultBitrate = defaultBitrate;
            this.Bitrates = bitrates;
            this.AllowAllIntensities = allowAllIntensities;
            this.DefaultIntensity = defaultIntensity;
            this.Intensities = intensities;
            this.AllowAllFormats = allowAllFormats;
            this.DefaultFormat = defaultFormat;
            this.TrackFormats = trackFormats;
            this.AllowAllModes = allowAllModes;
            this.DefaultMode = defaultMode;
            this.TrackModes = trackModes;
            this.ExpiredAt = expiredAt;
            this.CreatedAt = createdAt;
            this.LicenseLimits = licenseLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicensePublicResource" /> class.
        /// </summary>
        public LicensePublicResource()
        {
        }
    }
}