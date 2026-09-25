// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// var identifier = Reference.ByExternalId("which-brewing-fits-you");

(await client.DeleteAssetAsync(identifier)).EnsureSuccess();
