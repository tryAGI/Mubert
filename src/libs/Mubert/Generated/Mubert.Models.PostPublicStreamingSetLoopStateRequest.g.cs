
#nullable enable

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostPublicStreamingSetLoopStateRequest
    {
        /// <summary>
        /// Streaming Loop State
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mubert.JsonConverters.StreamingLoopStateEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mubert.StreamingLoopStateEnum Loop { get; set; }

        /// <summary>
        /// Set equal to the current stream playback time in seconds (since session start) to improve the UX<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public int? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStreamingSetLoopStateRequest" /> class.
        /// </summary>
        /// <param name="loop">
        /// Streaming Loop State
        /// </param>
        /// <param name="time">
        /// Set equal to the current stream playback time in seconds (since session start) to improve the UX<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostPublicStreamingSetLoopStateRequest(
            global::Mubert.StreamingLoopStateEnum loop,
            int? time)
        {
            this.Loop = loop;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPublicStreamingSetLoopStateRequest" /> class.
        /// </summary>
        public PostPublicStreamingSetLoopStateRequest()
        {
        }
    }
}