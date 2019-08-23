// DocSection: cm_api_v2_get_items
// Tip: Find more about .NET SDKs at https://developer.kenticocloud.com/docs/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ListingResponseModel<ContentItemModel> responseItems = await client.ListContentItemsAsync();
// EndDocSection