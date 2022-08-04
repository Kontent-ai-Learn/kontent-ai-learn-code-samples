// DocSection: cm_api_v2_patch_environment
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Models.Environments.Patch;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.ModifyEnvironmentAsync(new[]
{
        new EnvironmentRenamePatchModel
        {
            Value = "My Little Production"
        }
});
// EndDocSection