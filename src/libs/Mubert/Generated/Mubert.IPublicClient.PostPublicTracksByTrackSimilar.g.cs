#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Generate similar track<br/>
        /// Generate a new track similar to an existing one. Uses the original track parameters as a base and allows overriding duration, bitrate, format, intensity, and mode.
        /// </summary>
        /// <param name="track">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksByTrackSimilarResponse> PostPublicTracksByTrackSimilarAsync(
            global::System.Guid track,

            global::Mubert.PostPublicTracksByTrackSimilarRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate similar track<br/>
        /// Generate a new track similar to an existing one. Uses the original track parameters as a base and allows overriding duration, bitrate, format, intensity, and mode.
        /// </summary>
        /// <param name="track">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="duration">
        /// Duration of the track in seconds.<br/>
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
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksByTrackSimilarResponse> PostPublicTracksByTrackSimilarAsync(
            global::System.Guid track,
            int duration,
            int? bitrate = default,
            global::Mubert.TrackFormatEnum? format = default,
            global::Mubert.TrackIntensityEnum? intensity = default,
            global::Mubert.TrackModeEnum? mode = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}