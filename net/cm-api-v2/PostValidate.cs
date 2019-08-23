// DocSection: cm_api_v2_post_validate
using KenticoCloud.ContentManagement;
using KenticoCloud.ContentManagement.Models.ProjectReport;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

// Checks your project and stores the validation report in the response
ProjectReportModel response = await client.ValidateProjectAsync();
// EndDocSection