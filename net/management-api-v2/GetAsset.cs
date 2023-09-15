// DocSection: cm_api_v2_get_asset
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// var identifier = Reference.ByCodename("which-brewing-fits-you");

var response = await client.GetAssetAsync(identifier);

Assert.NotNull(response);
// EndDocSection