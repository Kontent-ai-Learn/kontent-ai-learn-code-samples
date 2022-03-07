// DocSection: cm_api_v2_mark_environment_as_production
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;
using Kentico.Kontent.Management.Models.Environments;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

await client.MarkEnvironmentAsProductionAsync(new MarkAsProductionModel
{
    EnableWebhooks = true
});
// EndDocSection