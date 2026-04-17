
#nullable enable

namespace Mubert
{
    /// <summary>
    /// Allowed BPM range
    /// </summary>
    public sealed partial class PlaylistPublicResourceParamBpm
    {
        /// <summary>
        /// Greater than BPM value<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// Lower than BPM value<br/>
        /// Example: 66
        /// </summary>
        /// <example>66</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistPublicResourceParamBpm" /> class.
        /// </summary>
        /// <param name="gt">
        /// Greater than BPM value<br/>
        /// Example: 45
        /// </param>
        /// <param name="lt">
        /// Lower than BPM value<br/>
        /// Example: 66
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistPublicResourceParamBpm(
            int? gt,
            int? lt)
        {
            this.Gt = gt;
            this.Lt = lt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistPublicResourceParamBpm" /> class.
        /// </summary>
        public PlaylistPublicResourceParamBpm()
        {
        }
    }
}