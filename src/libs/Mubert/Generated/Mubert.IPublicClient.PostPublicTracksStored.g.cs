#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Get stored track<br/>
        /// Retrieve a pre-generated track from the track-store. Returns a cached track matching the requested parameters if available.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksStoredResponse> PostPublicTracksStoredAsync(

            global::Mubert.PostPublicTracksStoredRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get stored track<br/>
        /// Retrieve a pre-generated track from the track-store. Returns a cached track matching the requested parameters if available.
        /// </summary>
        /// <param name="playlistIndex">
        /// The index of the playlist, required if stream_id is not provided.<br/>
        /// Example: 1.0.1
        /// </param>
        /// <param name="streamId">
        /// The ID of the stream, required if playlist_index is not provided.<br/>
        /// Example: 123
        /// </param>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="duration">
        /// The duration of the track in seconds.<br/>
        /// Example: 300
        /// </param>
        /// <param name="format">
        /// Enumeration representing different track formats.<br/>
        /// Example: mp3
        /// </param>
        /// <param name="intensity">
        /// Enumeration representing different intensity levels of a track.<br/>
        /// Example: medium
        /// </param>
        /// <param name="mode">
        /// Enumeration representing different modes of a track.<br/>
        /// Example: loop
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksStoredResponse> PostPublicTracksStoredAsync(
            int duration,
            string? playlistIndex = default,
            int? streamId = default,
            int? bitrate = default,
            global::Mubert.TrackFormatEnum? format = default,
            global::Mubert.TrackIntensityEnum? intensity = default,
            global::Mubert.TrackModeEnum? mode = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}