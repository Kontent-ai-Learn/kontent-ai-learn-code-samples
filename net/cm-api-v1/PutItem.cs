// DocSection: cm_api_v1_put_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

string externalId = "59713";

ContentItemUpsertModel item = new ContentItemUpsertModel()
{
    Name = "On Roasts",
    Type = ContentTypeIdentifier.ByCodename("article"),
  	SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") }
};

ContentItemModel contentItemResponse = await client.UpsertContentItemByExternalIdAsync(externalId, item);
// EndDocSection