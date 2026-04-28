namespace Revocalize.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RevocalizeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REVOCALIZE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("REVOCALIZE_API_KEY environment variable is not found.");

        var client = new RevocalizeClient(apiKey);
        
        return client;
    }
}
