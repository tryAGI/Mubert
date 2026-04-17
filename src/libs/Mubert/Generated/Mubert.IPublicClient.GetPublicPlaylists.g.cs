#nullable enable

namespace Mubert
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// List playlists<br/>
        /// Retrieve all available music channels, groups, and categories. Each entry includes a playlist_index identifier, category, group, channel name, and available parameters (BPM range, keys).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mubert.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mubert.GetPublicPlaylistsResponse> GetPublicPlaylistsAsync(
            global::Mubert.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}