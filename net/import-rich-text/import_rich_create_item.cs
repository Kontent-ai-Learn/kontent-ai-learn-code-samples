// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Items;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

(await client.UpsertContentItemAsync(Reference.ByExternalId("simple-example"), new ContentItemUpsertModel
{
    Name = "Simple example",
    Type = Reference.ByExternalId("simple-rich-text"),
})).EnsureSuccess();
