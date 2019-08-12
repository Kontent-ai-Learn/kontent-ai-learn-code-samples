// DocSection: cm_api_v2_add_item
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
    ExternalId = "59713"
};

ContentItemModel responseItem = await client.CreateContentItemAsync(item);
// EndDocSection
