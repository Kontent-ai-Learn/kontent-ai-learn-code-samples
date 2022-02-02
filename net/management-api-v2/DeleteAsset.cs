// DocSection: cm_api_v2_delete_asset
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// var identifier = Reference.ByExternalId("which-brewing-fits-you");

await client.DeleteAssetAsync(identifier);
// EndDocSection