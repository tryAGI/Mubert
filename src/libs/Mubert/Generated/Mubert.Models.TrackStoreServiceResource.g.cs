
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackStoreServiceResource
    {
        /// <summary>
        /// ID of the company associated with the track store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public global::System.Guid? CompanyId { get; set; }

        /// <summary>
        /// Available track bitrates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrates")]
        public global::System.Collections.Generic.IList<int>? Bitrates { get; set; }

        /// <summary>
        /// Available track durations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<int>? Durations { get; set; }

        /// <summary>
        /// Available track formats
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formats")]
        public global::System.Collections.Generic.IList<string>? Formats { get; set; }

        /// <summary>
        /// Available track intensities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensities")]
        public global::System.Collections.Generic.IList<string>? Intensities { get; set; }

        /// <summary>
        /// Available track modes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modes")]
        public global::System.Collections.Generic.IList<string>? Modes { get; set; }

        /// <summary>
        /// Total number of tracks available in the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_amount")]
        public int? TracksAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackStoreServiceResource" /> class.
        /// </summary>
        /// <param name="companyId">
        /// ID of the company associated with the track store
        /// </param>
        /// <param name="bitrates">
        /// Available track bitrates
        /// </param>
        /// <param name="durations">
        /// Available track durations
        /// </param>
        /// <param name="formats">
        /// Available track formats
        /// </param>
        /// <param name="intensities">
        /// Available track intensities
        /// </param>
        /// <param name="modes">
        /// Available track modes
        /// </param>
        /// <param name="tracksAmount">
        /// Total number of tracks available in the store
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackStoreServiceResource(
            global::System.Guid? companyId,
            global::System.Collections.Generic.IList<int>? bitrates,
            global::System.Collections.Generic.IList<int>? durations,
            global::System.Collections.Generic.IList<string>? formats,
            global::System.Collections.Generic.IList<string>? intensities,
            global::System.Collections.Generic.IList<string>? modes,
            int? tracksAmount)
        {
            this.CompanyId = companyId;
            this.Bitrates = bitrates;
            this.Durations = durations;
            this.Formats = formats;
            this.Intensities = intensities;
            this.Modes = modes;
            this.TracksAmount = tracksAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackStoreServiceResource" /> class.
        /// </summary>
        public TrackStoreServiceResource()
        {
        }
    }
}