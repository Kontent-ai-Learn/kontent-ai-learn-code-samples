// DocSection: cm_api_v2_mark_environment_as_production
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Models.Environments;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

await client.MarkEnvironmentAsProductionAsync(new MarkAsProductionModel
{
    EnableWebhooks = true
});
// EndDocSection