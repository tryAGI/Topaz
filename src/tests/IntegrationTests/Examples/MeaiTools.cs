/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to create MEAI AIFunction tools from the Topaz client.
*/

namespace Topaz.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create AIFunction tools from the Topaz client for use with any `IChatClient`.

        var apiKey =
            Environment.GetEnvironmentVariable("TOPAZ_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TOPAZ_API_KEY environment variable is not found.");

        using var client = new TopazClient(apiKey);

        //// Create tools that wrap the core async-job workflow:
        var enhanceImageTool = client.AsEnhanceImageTool();
        var getImageStatusTool = client.AsGetImageStatusTool();
        var downloadImageResultTool = client.AsDownloadImageResultTool();
        var getVideoStatusTool = client.AsGetVideoStatusTool();

        //// Wire them up to an IChatClient:
        //// ```csharp
        //// var options = new ChatOptions
        //// {
        ////     Tools = [enhanceImageTool, getImageStatusTool, downloadImageResultTool, getVideoStatusTool],
        //// };
        //// ```

        enhanceImageTool.Should().NotBeNull();
        enhanceImageTool.Name.Should().Be("TopazEnhanceImage");
        getImageStatusTool.Should().NotBeNull();
        getImageStatusTool.Name.Should().Be("TopazGetImageStatus");
        downloadImageResultTool.Should().NotBeNull();
        downloadImageResultTool.Name.Should().Be("TopazDownloadImageResult");
        getVideoStatusTool.Should().NotBeNull();
        getVideoStatusTool.Name.Should().Be("TopazGetVideoStatus");
    }
}
