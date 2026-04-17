#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get track by ID<br/>
        /// Retrieve specific track details including generation status, download URLs, and expiration times.
        /// </summary>
        /// <param name="track">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicTracksByTrackResponse> GetPublicTracksByTrackAsync(
            global::System.Guid track,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}