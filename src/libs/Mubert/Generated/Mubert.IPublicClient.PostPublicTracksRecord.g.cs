#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Record track<br/>
        /// Record a new track by sending a request directly to the track-recorder service, bypassing the track-store cache.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksRecordResponse> PostPublicTracksRecordAsync(

            global::Mubert.PostPublicTracksRecordRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record track<br/>
        /// Record a new track by sending a request directly to the track-recorder service, bypassing the track-store cache.
        /// </summary>
        /// <param name="playlistIndex">
        /// Index of the playlist. Required if `prompt`, and `image` are not provided. If provided, `bpm` and `key` can be optionally specified.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="prompt">
        /// Text prompt for track creation. Required if `playlist_index`, and `image` are not provided. If provided, `bpm` and `key` are not allowed.<br/>
        /// Example: Relaxing ambient music
        /// </param>
        /// <param name="image">
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
        /// </param>
        /// <param name="imagename">
        /// Image file for track creation. Required if `playlist_index` and `prompt` are not provided. If provided, `bpm` and `key` are not allowed. Supported formats: PNG, JPG, JPEG, WEBP, BMP. Size: 50 KB — 10 MB.
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
        /// <param name="bpm">
        /// Beats per minute (BPM). Can only be provided if `playlist_index` is specified. Not allowed if `prompt`, or `image` are used.<br/>
        /// Example: 120
        /// </param>
        /// <param name="key">
        /// Key-Scale for a track.<br/>
        /// Example: C#
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksRecordResponse> PostPublicTracksRecordAsync(
            int duration,
            string? playlistIndex = default,
            string? prompt = default,
            byte[]? image = default,
            string? imagename = default,
            int? bitrate = default,
            global::Mubert.TrackFormatEnum? format = default,
            global::Mubert.TrackIntensityEnum? intensity = default,
            global::Mubert.TrackModeEnum? mode = default,
            int? bpm = default,
            global::Mubert.TrackKeyScaleEnum? key = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}