// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Models.Environments;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CloneEnvironmentAsync(new EnvironmentCloneModel
{
    Name = "New environment",
    RolesToActivate = new[]
    {
        Guid.Parse("2f925111-1457-49d4-a595-0958feae8ae4")
    }
});
