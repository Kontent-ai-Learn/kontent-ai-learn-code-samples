// DocSection: cm_api_v1_post_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ContentItemCreateModel item = new ContentItemCreateModel
{
    Name = "On Roasts",
    Type = ContentTypeIdentifier.ByCodename("article"),
    SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") },
    ExternalId = "59713"
};

ContentItemModel responseItem = await client.CreateContentItemAsync(item);
// EndDocSection