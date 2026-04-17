#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Set stream loop state<br/>
        /// Enable or disable loop mode for the current stream segment. When enabled, the later part of the music composition will loop continuously.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task PostPublicStreamingSetLoopStateAsync(

            global::Mubert.PostPublicStreamingSetLoopStateRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set stream loop state<br/>
        /// Enable or disable loop mode for the current stream segment. When enabled, the later part of the music composition will loop continuously.
        /// </summary>
        /// <param name="loop">
        /// Streaming Loop State
        /// </param>
        /// <param name="time">
        /// Set equal to the current stream playback time in seconds (since session start) to improve the UX<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostPublicStreamingSetLoopStateAsync(
            global::Mubert.StreamingLoopStateEnum loop,
            int? time = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}