// DocSection: mapi_v2_get_validation_task
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.GetAsyncValidationTaskAsync(Guid.Parse("88d94fed-4899-4944-9b4b-c919b11a9db0"));
// EndDocSection