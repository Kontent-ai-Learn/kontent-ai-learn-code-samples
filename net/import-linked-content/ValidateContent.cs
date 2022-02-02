// DocSection: import_linked_validate_content
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

ManagementClient client = new ManagementClient(options);

var response = await client.ValidateProjectAsync();
// EndDocSection