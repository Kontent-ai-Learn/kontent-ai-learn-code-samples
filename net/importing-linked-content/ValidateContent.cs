// DocSection: import_linked_validate_content
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;
using Kentico.Kontent.Management.Models.ProjectReport;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ProjectReportModel response = await client.ValidateProjectAsync();
// EndDocSection