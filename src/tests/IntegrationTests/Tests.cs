namespace Reverie.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ReverieClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REVERIE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("REVERIE_API_KEY environment variable is not found.");
        var appId =
            Environment.GetEnvironmentVariable("REVERIE_APP_ID") is { Length: > 0 } appIdValue
                ? appIdValue
                : throw new AssertInconclusiveException("REVERIE_APP_ID environment variable is not found.");

        var client = new ReverieClient(apiKey, appId);
        
        return client;
    }
}
