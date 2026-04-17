#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Set stream intensity<br/>
        /// Dynamically adjust the arrangement complexity during streaming. Changes occur seamlessly without stream interruption.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task PostPublicStreamingSetIntensityAsync(

            global::Mubert.PostPublicStreamingSetIntensityRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set stream intensity<br/>
        /// Dynamically adjust the arrangement complexity during streaming. Changes occur seamlessly without stream interruption.
        /// </summary>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostPublicStreamingSetIntensityAsync(
            global::Mubert.TrackIntensityEnum intensity,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}