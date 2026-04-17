/*
order: 20
title: Playlists and Streaming
slug: playlists-streaming

Shows how to discover Mubert playlist channels and request a live streaming URL.
*/

namespace Mubert.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListPlaylists()
    {
        //// Retrieve all available Mubert channels grouped by category/group/channel.

        using var client = GetAuthenticatedClient();

        var response = await client.Public.GetPublicPlaylistsAsync();

        response.Data.Should().NotBeNull();
        response.Data!.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Example_StreamingGetLink()
    {
        //// Get a live HTTP streaming URL for a Mubert channel.

        using var client = GetAuthenticatedClient();

        var response = await client.Public.GetPublicStreamingGetLinkAsync(
            playlistIndex: "1.0.0",
            bitrate: 128,
            intensity: TrackIntensityEnum.Medium,
            type: StreamingTypeEnum.Http);

        response.Data.Should().NotBeNull();
        response.Data!.Link.Should().NotBeNullOrWhiteSpace();
    }
}
