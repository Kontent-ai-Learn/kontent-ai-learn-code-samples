// DocSection: importing_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ContentItemCreateModel item = new ContentItemCreateModel
{
    Name = "Brno",
    Type = ContentTypeIdentifier.ByCodename("cafe"),
    SitemapLocations = new[] { 
      SitemapNodeIdentifier.ByCodename("cafes"),
      SitemapNodeIdentifier.ByCodename("europe")
    },
    ExternalId = "ext-cafe-brno";
};

ContentItemModel responseItem = await client.CreateContentItemAsync(item);
// EndDocSection