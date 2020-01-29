// DocSection: importing_create_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

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