// DocSection: import_rich_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.UpsertContentItemByExternalIdAsync("simple-example", new ContentItemUpsertModel
{
    Name = "Simple example",
    Type = Reference.ByExternalId("simple-rich-text"),
});
// EndDocSection