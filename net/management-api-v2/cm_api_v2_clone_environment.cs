// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Models.Environments;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CloneEnvironmentAsync(new EnvironmentCloneModel
{
    Name = "New environment",
    RolesToActivate = new[]
    {
        Guid.Parse("ee483b59-5a24-4010-b277-ae224c34bc71")
    },
    CopyDataOptions = new CopyDataOptions {
        ContentItemsAssets = true,
        ContentItemVersionHistory = false
    }
});
