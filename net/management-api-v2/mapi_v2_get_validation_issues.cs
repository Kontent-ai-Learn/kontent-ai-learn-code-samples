// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.ListAsyncValidationTaskIssuesAsync(Guid.Parse("88d94fed-4899-4944-9b4b-c919b11a9db0"));
