// DocSection: cm_api_v2_get_assets
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

// Gets all pages of results
var response = await client.ListAssetsAsync();
// EndDocSection