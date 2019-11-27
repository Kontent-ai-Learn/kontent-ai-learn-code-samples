// DocSection: cm_api_v2_get_assets
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ListingResponseModel<AssetModel> responseAssets = await client.ListAssetsAsync();
// EndDocSection