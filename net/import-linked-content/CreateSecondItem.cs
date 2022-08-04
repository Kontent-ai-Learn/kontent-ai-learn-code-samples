// DocSection: import_linked_create_sec_item
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.UpsertContentItemAsync(
    Reference.ByExternalId("456"),
    new ContentItemUpsertModel { Name = "Donate with us", Type = Reference.ByCodename("article") });
// EndDocSection