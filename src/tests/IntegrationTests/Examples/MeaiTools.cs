/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use Mubert as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Mubert.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_AsTextToMusicTool()
    {
        //// Use the text-to-music tool to generate Mubert music from a prompt.
        //// Pass this tool to any IChatClient via ChatOptions.Tools.

        using var client = new MubertClient(customerId: "dummy", accessToken: "dummy");

        AIFunction tool = client.AsTextToMusicTool();

        tool.Name.Should().Be("MubertTextToMusic");
        tool.Description.Should().Contain("prompt");
    }

    [TestMethod]
    public void Example_AsGenerateTrackTool()
    {
        //// Use the playlist-based generation tool with a category.group.channel index.

        using var client = new MubertClient(customerId: "dummy", accessToken: "dummy");

        AIFunction tool = client.AsGenerateTrackTool();

        tool.Name.Should().Be("MubertGenerateTrack");
        tool.Description.Should().Contain("playlist");
    }

    [TestMethod]
    public void Example_AsGetTrackStatusTool()
    {
        //// Use the track status tool to poll a previously generated track.

        using var client = new MubertClient(customerId: "dummy", accessToken: "dummy");

        AIFunction tool = client.AsGetTrackStatusTool();

        tool.Name.Should().Be("MubertGetTrackStatus");
        tool.Description.Should().Contain("status");
    }

    [TestMethod]
    public void Example_AsListPlaylistsTool()
    {
        //// Use the list-playlists tool to discover available channels.

        using var client = new MubertClient(customerId: "dummy", accessToken: "dummy");

        AIFunction tool = client.AsListPlaylistsTool();

        tool.Name.Should().Be("MubertListPlaylists");
        tool.Description.Should().Contain("channels");
    }

    [TestMethod]
    public void Example_AsStreamMusicTool()
    {
        //// Use the streaming tool to fetch a live streaming URL.

        using var client = new MubertClient(customerId: "dummy", accessToken: "dummy");

        AIFunction tool = client.AsStreamMusicTool();

        tool.Name.Should().Be("MubertStreamMusic");
        tool.Description.Should().Contain("streaming");
    }
}
