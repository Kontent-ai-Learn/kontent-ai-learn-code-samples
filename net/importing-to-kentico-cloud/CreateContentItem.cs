// DocSection: importing_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.UpsertContentItemByExternalIdAsync("ext-cafe-brno", new ContentItemUpsertModel
{
    Name = "Brno",
    Type = Reference.ByExternalId("cafe"),
});
// EndDocSection