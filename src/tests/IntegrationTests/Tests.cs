namespace Mubert.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MubertClient GetAuthenticatedClient()
    {
        var customerId =
            Environment.GetEnvironmentVariable("MUBERT_CUSTOMER_ID") is { Length: > 0 } customerIdValue
                ? customerIdValue
                : throw new AssertInconclusiveException("MUBERT_CUSTOMER_ID environment variable is not found.");

        var accessToken =
            Environment.GetEnvironmentVariable("MUBERT_ACCESS_TOKEN") is { Length: > 0 } accessTokenValue
                ? accessTokenValue
                : throw new AssertInconclusiveException("MUBERT_ACCESS_TOKEN environment variable is not found.");

        var client = new MubertClient(customerId, accessToken);

        return client;
    }
}
