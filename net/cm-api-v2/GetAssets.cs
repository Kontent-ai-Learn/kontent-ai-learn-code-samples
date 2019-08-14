// DocSection: cm_api_v2_get_assets
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ListingResponseModel<AssetModel> responseAssets = await client.ListAssetsAsync();
// EndDocSection