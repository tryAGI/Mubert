#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// List music library tracks<br/>
        /// Retrieve a paginated list of pre-generated music library tracks with optional filtering by genre, mood, BPM, key, and other parameters.
        /// </summary>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 25
        /// </param>
        /// <param name="order">
        /// Example: asc
        /// </param>
        /// <param name="orderBy">
        /// Example: created_at
        /// </param>
        /// <param name="bpm">
        /// Example: 120
        /// </param>
        /// <param name="key">
        /// Key-Scale for a track.<br/>
        /// Example: C#
        /// </param>
        /// <param name="genres">
        /// Example: Rock
        /// </param>
        /// <param name="moods">
        /// Example: Happy
        /// </param>
        /// <param name="activities">
        /// Example: Minimal 170
        /// </param>
        /// <param name="playlists">
        /// Example: Chill Vibes
        /// </param>
        /// <param name="instruments">
        /// Example: Guitar
        /// </param>
        /// <param name="themes">
        /// Example: Corporate
        /// </param>
        /// <param name="duration">
        /// Example: 180
        /// </param>
        /// <param name="mode">
        /// Enumeration representing different modes of a track.<br/>
        /// Example: loop
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicMusicLibraryTracksResponse> GetPublicMusicLibraryTracksAsync(
            int? offset = default,
            int? limit = default,
            global::Mubert.GetPublicMusicLibraryTracksOrder? order = default,
            string? orderBy = default,
            int? bpm = default,
            global::Mubert.TrackKeyScaleEnum? key = default,
            string? genres = default,
            string? moods = default,
            string? activities = default,
            string? playlists = default,
            string? instruments = default,
            string? themes = default,
            int? duration = default,
            global::Mubert.TrackModeEnum? mode = default,
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}