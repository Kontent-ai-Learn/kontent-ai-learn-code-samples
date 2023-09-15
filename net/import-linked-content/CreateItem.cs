// DocSection: import_linked_create_item
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

await client.UpsertContentItemAsync(
    Reference.ByExternalId("123"),
    new ContentItemUpsertModel { Name = "On Roasts", Type = Reference.ByCodename("article") });
// EndDocSection