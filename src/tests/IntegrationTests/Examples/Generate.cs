/*
order: 10
title: Music Generation
slug: music-generation

Shows how to generate Mubert AI music tracks from a text prompt or a playlist channel.
*/

namespace Mubert.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateTrack_TextPrompt()
    {
        //// Generate a Mubert track from a natural-language prompt.

        using var client = GetAuthenticatedClient();

        var response = await client.Public.PostPublicTracksAsync(
            new PostPublicTracksRequest
            {
                Prompt = "Uplifting ambient chillwave with dreamy pads",
                Duration = 60,
                Intensity = TrackIntensityEnum.Medium,
                Format = TrackFormatEnum.Mp3,
            });

        response.Data.Should().NotBeNull();
        response.Data!.Id.Should().NotBe(Guid.Empty);
    }

    [TestMethod]
    public async Task Example_GenerateTrack_FromPlaylist()
    {
        //// Generate a Mubert track using a playlist index (category.group.channel).

        using var client = GetAuthenticatedClient();

        var response = await client.Public.PostPublicTracksAsync(
            new PostPublicTracksRequest
            {
                PlaylistIndex = "1.0.0",
                Duration = 60,
                Intensity = TrackIntensityEnum.High,
                Mode = TrackModeEnum.Track,
            });

        response.Data.Should().NotBeNull();
        response.Data!.Id.Should().NotBe(Guid.Empty);
    }
}
