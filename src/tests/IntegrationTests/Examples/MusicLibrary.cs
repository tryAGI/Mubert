/*
order: 30
title: Music Library
slug: music-library

Shows how to browse Mubert's curated music library and filter parameters.
*/

namespace Mubert.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MusicLibraryParams()
    {
        //// Discover available filter values (genres, moods, BPMs, etc.) for the curated library.

        using var client = GetAuthenticatedClient();

        var response = await client.Public.GetPublicMusicLibraryParamsAsync();

        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_MusicLibraryTracks()
    {
        //// Browse curated library tracks with paging.

        using var client = GetAuthenticatedClient();

        var response = await client.Public.GetPublicMusicLibraryTracksAsync(
            limit: 10,
            offset: 0);

        response.Data.Should().NotBeNull();
    }
}
