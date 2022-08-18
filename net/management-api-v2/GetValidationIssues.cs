// DocSection: mapi_v2_get_validation_issues
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.ListAsyncValidationTaskIssuesAsync(Guid.Parse("88d94fed-4899-4944-9b4b-c919b11a9db0"));
// EndDocSection