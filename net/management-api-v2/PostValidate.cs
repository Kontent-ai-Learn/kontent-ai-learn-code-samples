// DocSection: cm_api_v2_post_validate
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;
using Kentico.Kontent.Management.Models.ProjectReport;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

// Checks your project and stores the validation report in the response
ProjectReportModel response = await client.ValidateProjectAsync();
// EndDocSection