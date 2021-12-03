// DocSection: import_linked_create_sec_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.UpsertContentItemByExternalIdAsync("456", new ContentItemUpsertModel
{
    Name = "Donate with us",
    Type = Reference.ByCodename("article"),
});
// EndDocSection