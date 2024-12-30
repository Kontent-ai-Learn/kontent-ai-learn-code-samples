// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

await client.UpsertContentItemAsync(
    Reference.ByExternalId("123"),
    new ContentItemUpsertModel { Name = "On Roasts", Type = Reference.ByCodename("article") });
