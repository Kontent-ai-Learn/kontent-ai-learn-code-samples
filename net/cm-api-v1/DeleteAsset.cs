// DocSection: cm_api_v1_delete_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

AssetIdentifier identifier = AssetIdentifier.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// AssetIdentifier identifier = AssetIdentifier.ByExternalId("which-brewing-fits-you");

await client.DeleteAssetAsync(identifier);
// EndDocSection