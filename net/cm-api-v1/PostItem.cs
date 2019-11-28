// DocSection: cm_api_v1_post_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ContentItemCreateModel item = new ContentItemCreateModel
{
    Name = "On Roasts",
    Type = ContentTypeIdentifier.ByCodename("article"),
    SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") },
    ExternalId = "59713"
};

ContentItemModel responseItem = await client.CreateContentItemAsync(item);
// EndDocSection