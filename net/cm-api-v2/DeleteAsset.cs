// DocSection: cm_api_v2_delete_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

AssetIdentifier identifier = AssetIdentifier.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// AssetIdentifier identifier = AssetIdentifier.ByExternalId("which-brewing-fits-you");

await client.DeleteAssetAsync(identifier);
// EndDocSection