#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Edit track<br/>
        /// Modify track parameters or manipulate instrument/stem composition. Allows changing duration, bitrate, format, intensity, as well as replacing or removing specific instruments and stems.
        /// </summary>
        /// <param name="track">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksByTrackEditResponse> PostPublicTracksByTrackEditAsync(
            global::System.Guid track,

            global::Mubert.PostPublicTracksByTrackEditRequest request,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit track<br/>
        /// Modify track parameters or manipulate instrument/stem composition. Allows changing duration, bitrate, format, intensity, as well as replacing or removing specific instruments and stems.
        /// </summary>
        /// <param name="track">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="bitrate">
        /// Enumeration representing different track bitrates.<br/>
        /// Example: 320
        /// </param>
        /// <param name="duration">
        /// The duration of the track in seconds. Must be between 5 and 3600.<br/>
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
        /// <param name="replaceStems">
        /// Replace stems
        /// </param>
        /// <param name="deleteStems">
        /// Delete stems
        /// </param>
        /// <param name="replaceInstruments">
        /// Replace instruments
        /// </param>
        /// <param name="deleteInstruments">
        /// Delete instruments
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.PostPublicTracksByTrackEditResponse> PostPublicTracksByTrackEditAsync(
            global::System.Guid track,
            int? bitrate = default,
            int? duration = default,
            global::Mubert.TrackFormatEnum? format = default,
            global::Mubert.TrackIntensityEnum? intensity = default,
            global::System.Collections.Generic.IList<global::Mubert.StemEnum>? replaceStems = default,
            global::System.Collections.Generic.IList<global::Mubert.StemEnum>? deleteStems = default,
            global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? replaceInstruments = default,
            global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>? deleteInstruments = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}