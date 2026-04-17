#nullable enable

using Microsoft.Extensions.AI;

namespace Mubert;

/// <summary>
/// Extensions for using MubertClient as Microsoft.Extensions.AI tools with any IChatClient.
/// </summary>
public static class MubertToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a music track from a text prompt
    /// using Mubert's text-to-music endpoint.
    /// </summary>
    /// <param name="client">The Mubert client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [System.CLSCompliant(false)]
    public static AIFunction AsTextToMusicTool(this MubertClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, int duration, int? bitrate, string? intensity, string? mode, string? format, CancellationToken cancellationToken) =>
            {
                var response = await client.Public.PostPublicTracksAsync(
                    new PostPublicTracksRequest
                    {
                        Prompt = prompt,
                        Duration = duration,
                        Bitrate = bitrate,
                        Intensity = ParseIntensity(intensity),
                        Mode = ParseMode(mode),
                        Format = ParseFormat(format),
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTrack(response.Data);
            },
            name: "MubertTextToMusic",
            description: "Generates a royalty-free Mubert AI music track from a natural-language prompt. 'duration' is in seconds (min 5). Optional: bitrate (32/96/128/192/256/320), intensity ('low'/'medium'/'high'), mode ('track'/'loop'/'jingle'/'mix'), format ('mp3'/'wav').");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a music track from a Mubert playlist
    /// channel (category/group/channel index) using parameter-based generation.
    /// </summary>
    /// <param name="client">The Mubert client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [System.CLSCompliant(false)]
    public static AIFunction AsGenerateTrackTool(this MubertClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string playlistIndex, int duration, int? bpm, int? bitrate, string? intensity, string? mode, string? format, CancellationToken cancellationToken) =>
            {
                var response = await client.Public.PostPublicTracksAsync(
                    new PostPublicTracksRequest
                    {
                        PlaylistIndex = playlistIndex,
                        Duration = duration,
                        Bpm = bpm,
                        Bitrate = bitrate,
                        Intensity = ParseIntensity(intensity),
                        Mode = ParseMode(mode),
                        Format = ParseFormat(format),
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTrack(response.Data);
            },
            name: "MubertGenerateTrack",
            description: "Generates a Mubert music track using a playlist index (e.g. '1.0.0' - category.group.channel). Call MubertListPlaylists first to discover valid indexes. 'duration' is in seconds (min 5). Optional: bpm, bitrate, intensity ('low'/'medium'/'high'), mode ('track'/'loop'/'jingle'/'mix'), format ('mp3'/'wav').");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the current status of a previously
    /// generated Mubert track.
    /// </summary>
    /// <param name="client">The Mubert client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [System.CLSCompliant(false)]
    public static AIFunction AsGetTrackStatusTool(this MubertClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string trackId, CancellationToken cancellationToken) =>
            {
                if (!Guid.TryParse(trackId, out var guid))
                {
                    return $"Invalid trackId '{trackId}' (must be a GUID).";
                }

                var response = await client.Public.GetPublicTracksByTrackAsync(
                    track: guid,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTrack(response.Data);
            },
            name: "MubertGetTrackStatus",
            description: "Fetches the current status and download URL(s) of a previously generated Mubert track by its GUID id.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Mubert playlist channels
    /// (category / group / channel). Each channel can be used as a playlist_index.
    /// </summary>
    /// <param name="client">The Mubert client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [System.CLSCompliant(false)]
    public static AIFunction AsListPlaylistsTool(this MubertClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Public.GetPublicPlaylistsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { "Available Mubert channels:" };
                foreach (var p in response.Data ?? [])
                {
                    parts.Add($"- {p.PlaylistIndex}  [{p.Category} / {p.Group} / {p.Channel}]");
                }
                return string.Join("\n", parts);
            },
            name: "MubertListPlaylists",
            description: "Lists all available Mubert playlist channels. Returns each channel's playlist_index plus category/group/channel names. Use the playlist_index values with MubertGenerateTrack or MubertStreamMusic.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns a live-streaming URL for a Mubert
    /// channel, which continuously serves adaptive generative music.
    /// </summary>
    /// <param name="client">The Mubert client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [System.CLSCompliant(false)]
    public static AIFunction AsStreamMusicTool(this MubertClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string playlistIndex, int? bitrate, string? intensity, string? type, CancellationToken cancellationToken) =>
            {
                var response = await client.Public.GetPublicStreamingGetLinkAsync(
                    playlistIndex: playlistIndex,
                    bitrate: bitrate,
                    intensity: ParseIntensity(intensity),
                    type: ParseStreamingType(type),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var link = response.Data?.Link;
                return string.IsNullOrWhiteSpace(link)
                    ? "Streaming URL unavailable."
                    : $"Streaming URL: {link}";
            },
            name: "MubertStreamMusic",
            description: "Returns a live HTTP/WebRTC streaming URL for continuous adaptive Mubert music on a playlist channel (playlist_index like '1.0.0'). Optional: bitrate, intensity ('low'/'medium'/'high'), type ('http'/'webrtc').");
    }

    // Mubert enum values are lowercase on the wire; normalise user input the same way.
#pragma warning disable CA1308
    private static TrackIntensityEnum? ParseIntensity(string? intensity)
        => intensity is null ? null : TrackIntensityEnumExtensions.ToEnum(intensity.ToLowerInvariant());

    private static TrackModeEnum? ParseMode(string? mode)
        => mode is null ? null : TrackModeEnumExtensions.ToEnum(mode.ToLowerInvariant());

    private static TrackFormatEnum? ParseFormat(string? format)
        => format is null ? null : TrackFormatEnumExtensions.ToEnum(format.ToLowerInvariant());

    private static StreamingTypeEnum? ParseStreamingType(string? type)
        => type is null ? null : StreamingTypeEnumExtensions.ToEnum(type.ToLowerInvariant());
#pragma warning restore CA1308

    private static string FormatTrack(TrackPublicResource? track)
    {
        if (track is null)
        {
            return "No track data returned.";
        }

        var parts = new List<string>
        {
            $"Track id: {track.Id}",
        };

        if (!string.IsNullOrWhiteSpace(track.SessionId))
        {
            parts.Add($"Session: {track.SessionId}");
        }
        if (!string.IsNullOrWhiteSpace(track.PlaylistIndex))
        {
            parts.Add($"Playlist: {track.PlaylistIndex}");
        }
        if (!string.IsNullOrWhiteSpace(track.Prompt))
        {
            parts.Add($"Prompt: {track.Prompt}");
        }
        if (track.Duration is int dur)
        {
            parts.Add($"Duration: {dur}s");
        }
        if (!string.IsNullOrWhiteSpace(track.Mode))
        {
            parts.Add($"Mode: {track.Mode}");
        }
        if (track.Bpm is int bpm)
        {
            parts.Add($"BPM: {bpm}");
        }
        if (!string.IsNullOrWhiteSpace(track.Key))
        {
            parts.Add($"Key: {track.Key}");
        }
        if (track.CreatedAt is { } created)
        {
            parts.Add($"Created: {created:O}");
        }

        return string.Join("\n", parts);
    }
}
