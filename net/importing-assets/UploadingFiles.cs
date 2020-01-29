// DocSection: importing_assets_upload_file
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "Bearer <YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

string filePath = Path.Combine(AppContext.BaseDirectory, @".\<YOUR_PATH>\brno-cafe-1080px.jpg");
string contentType = "image/jpg";

// Binary file reference to be used when adding a new asset
FileReference fileResult = await client.UploadFileAsync(new FileContentSource(filePath, contentType));
// EndDocSection