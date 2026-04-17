
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaylistPublicResourceParam
    {
        /// <summary>
        /// Allowed BPM range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public global::Mubert.PlaylistPublicResourceParamBpm? Bpm { get; set; }

        /// <summary>
        /// Allowed musical keys for the specified BPM range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackKeyScaleEnum>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistPublicResourceParam" /> class.
        /// </summary>
        /// <param name="bpm">
        /// Allowed BPM range
        /// </param>
        /// <param name="keys">
        /// Allowed musical keys for the specified BPM range
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistPublicResourceParam(
            global::Mubert.PlaylistPublicResourceParamBpm? bpm,
            global::System.Collections.Generic.IList<global::Mubert.TrackKeyScaleEnum>? keys)
        {
            this.Bpm = bpm;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistPublicResourceParam" /> class.
        /// </summary>
        public PlaylistPublicResourceParam()
        {
        }
    }
}