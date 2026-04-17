
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackIndexPublicResourceVariant2
    {
        /// <summary>
        /// List of track generations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::Mubert.TrackGenerationIndexPublicResource>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackIndexPublicResourceVariant2" /> class.
        /// </summary>
        /// <param name="generations">
        /// List of track generations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackIndexPublicResourceVariant2(
            global::System.Collections.Generic.IList<global::Mubert.TrackGenerationIndexPublicResource>? generations)
        {
            this.Generations = generations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackIndexPublicResourceVariant2" /> class.
        /// </summary>
        public TrackIndexPublicResourceVariant2()
        {
        }
    }
}