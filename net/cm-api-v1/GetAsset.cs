// DocSection: cm_api_v1_get_asset
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

AssetIdentifier identifier = AssetIdentifier.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// AssetIdentifier identifier = AssetIdentifier.ByExternalId("which-brewing-fits-you");

AssetModel responseAssets = await client.GetAssetAsync(identifier);
// EndDocSection