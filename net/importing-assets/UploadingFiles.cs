// DocSection: importing_assets_upload_file
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "Bearer <YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

string filePath = Path.Combine(AppContext.BaseDirectory, @"<YOUR_PATH>\brno-cafe-1080px.jpg");
string contentType = "image/jpg";

// Binary file reference to be used when adding a new asset
FileReference fileResult = await client.UploadFileAsync(new FileContentSource(filePath, contentType));
// EndDocSection