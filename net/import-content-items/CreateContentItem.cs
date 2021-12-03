// DocSection: importing_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions()
{
    ApiKey = "<YOUR_MANAGEMENT_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ContentItemUpsertModel item = new ContentItemUpsertModel()
{
    Name = "Brno",
    Type = ContentTypeIdentifier.ByCodename("cafe")
};

ContentItemModel responseItem = await client.UpsertContentItemByExternalIdAsync("ext-cafe-brno", item);
// EndDocSection