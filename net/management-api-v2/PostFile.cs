// DocSection: cm_api_v2_post_file
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var filePath = Path.Combine(Environment.CurrentDirectory, "Unit", "Data", "kentico_rgb_bigger.png");
var contentType = "image/png";

// Binary file reference to be used when adding a new asset
var response = await client.UploadFileAsync(new FileContentSource(filePath, contentType));
// EndDocSection