// DocSection: import_linked_create_sec_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};
ManagementClient client = new ManagementClient(options);

string externalId = "456";
ContentItemUpsertModel item = new ContentItemUpsertModel()
{
    Name = "Donate with us",
    Type = ContentTypeIdentifier.ByCodename("article"),
    SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") }
};

ContentItemModel contentItemResponse = await client.UpsertContentItemByExternalIdAsync(externalId, item);
// EndDocSection