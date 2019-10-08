// DocSection: importing_assets_upload_file
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "Bearer <YOUR_API_KEY>",
    ProjectId = "14372844-0a5d-434a-8423-605b8a631623"
};

ContentManagementClient client = new ContentManagementClient(options);

string filePath = Path.Combine(AppContext.BaseDirectory, @"<YOUR_PATH>\brno-cafe-1080px.jpg");
string contentType = "image/jpg";

// Binary file reference to be used when adding a new asset
FileReference fileResult = await client.UploadFileAsync(new FileContentSource(filePath, contentType));
// EndDocSection