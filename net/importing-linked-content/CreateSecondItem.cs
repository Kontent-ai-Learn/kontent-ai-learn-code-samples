// DocSection: import_linked_create_sec_item
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};
ContentManagementClient client = new ContentManagementClient(options);

string externalId = "456";
ContentItemUpsertModel item = new ContentItemUpsertModel()
{
    Name = "Donate with us",
    Type = ContentTypeIdentifier.ByCodename("article"),
    SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") }
};

ContentItemModel contentItemResponse = await client.UpsertContentItemByExternalIdAsync(externalId, item);
// EndDocSection