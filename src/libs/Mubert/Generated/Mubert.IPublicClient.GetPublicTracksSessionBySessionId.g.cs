#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get track by session ID<br/>
        /// Retrieve specific track details by session ID including generation status, download URLs, and expiration times.
        /// </summary>
        /// <param name="track">
        /// Example: 4b19470aec7446d0a8e3c05d06b23ce2
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicTracksSessionBySessionIdResponse> GetPublicTracksSessionBySessionIdAsync(
            string track,
            string sessionId,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}