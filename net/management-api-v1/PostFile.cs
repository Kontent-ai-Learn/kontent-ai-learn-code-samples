// DocSection: cm_api_v1_post_file
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

string filePath = Path.Combine(AppContext.BaseDirectory, @"<YOUR_PATH>\which-brewing-fits-you-1080px.jpg");
string contentType = "image/jpeg";

// Binary file reference to be used when adding a new asset
FileReference fileReference = await client.UploadFileAsync(new FileContentSource(filePath, contentType));

// To create an asset, see the "Add an asset" endpoint
// EndDocSection