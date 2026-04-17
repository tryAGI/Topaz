namespace Topaz.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TopazClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TOPAZ_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TOPAZ_API_KEY environment variable is not found.");

        var client = new TopazClient(apiKey);
        
        return client;
    }
}
