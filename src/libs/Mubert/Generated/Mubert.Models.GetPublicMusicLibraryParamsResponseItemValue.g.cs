
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicMusicLibraryParamsResponseItemValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_count")]
        public int? TracksCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryParamsResponseItemValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tracksCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPublicMusicLibraryParamsResponseItemValue(
            string? value,
            int? tracksCount)
        {
            this.Value = value;
            this.TracksCount = tracksCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicMusicLibraryParamsResponseItemValue" /> class.
        /// </summary>
        public GetPublicMusicLibraryParamsResponseItemValue()
        {
        }
    }
}