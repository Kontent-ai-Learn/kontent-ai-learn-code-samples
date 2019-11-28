// DocSection: cm_api_v2_get_assets
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ListingResponseModel<AssetModel> responseAssets = await client.ListAssetsAsync();
// EndDocSection