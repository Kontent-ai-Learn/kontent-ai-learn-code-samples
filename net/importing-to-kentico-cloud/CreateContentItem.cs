// DocSection: importing_create_item
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "14372844-0a5d-434a-8423-605b8a631623"
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