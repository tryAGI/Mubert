
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicStreamingSetIntensityRequest
    {
        /// <summary>
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.TrackIntensityEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mubert.TrackIntensityEnum Intensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStreamingSetIntensityRequest" /> class.
        /// </summary>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicStreamingSetIntensityRequest(
            global::Mubert.TrackIntensityEnum intensity)
        {
            this.Intensity = intensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStreamingSetIntensityRequest" /> class.
        /// </summary>
        public PostPublicStreamingSetIntensityRequest()
        {
        }
    }
}