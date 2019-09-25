// DocSection: cm_api_v1_get_items
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ListingResponseModel<ContentItemModel> responseItems = await client.ListContentItemsAsync();
// EndDocSection