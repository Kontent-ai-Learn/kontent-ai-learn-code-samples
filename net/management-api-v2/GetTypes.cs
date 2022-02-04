// DocSection: cm_api_v2_get_types
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

// Gets the first page of results
var response = await client.ListContentTypesAsync();
// EndDocSection
