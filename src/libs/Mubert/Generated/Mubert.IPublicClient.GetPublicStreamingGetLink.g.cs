#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get streaming link<br/>
        /// Generate a streaming URL for continuous music playback. The returned link can be used in any audio player that supports HTTP streaming or WebRTC.
        /// </summary>
        /// <param name="playlistIndex">
        /// Example: 1.0.0
        /// </param>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
        /// <param name="type">
        /// Streaming Type Enum
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicStreamingGetLinkResponse> GetPublicStreamingGetLinkAsync(
            string playlistIndex,
            int? bitrate = default,
            global::Mubert.TrackIntensityEnum? intensity = default,
            global::Mubert.StreamingTypeEnum? type = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}