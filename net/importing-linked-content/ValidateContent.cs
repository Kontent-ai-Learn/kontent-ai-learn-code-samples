// DocSection: import_linked_validate_content
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using CM API v1
using KenticoCloud.ContentManagement;
using KenticoCloud.ContentManagement.Models.ProjectReport;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ProjectReportModel response = await client.ValidateProjectAsync();
// EndDocSection