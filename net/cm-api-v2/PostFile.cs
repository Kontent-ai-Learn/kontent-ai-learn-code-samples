// DocSection: cm_api_v2_post_file
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

string filePath = Path.Combine(AppContext.BaseDirectory, @"<YOUR_PATH>\which-brewing-fits-you-1080px.jpg");
string contentType = "image/jpeg";

// Binary file reference to be used when adding a new asset
FileReference fileReference = await client.UploadFileAsync(new FileContentSource(filePath, contentType));

// To create an asset, see the "Add an asset" endpoint
// EndDocSection