// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateAssetFoldersAsync(new AssetFolderCreateModel
{
    Folders = new[]
    {
        new AssetFolderHierarchy
        {
            Name = "Top level folder",
            ExternalId = "top-folder",
            Folders = new []
            {
                new AssetFolderHierarchy
                {
                    Name = "Second level folder",
                    ExternalId = "second-folder",
                    Folders = Enumerable.Empty<AssetFolderHierarchy>(),
                }
            }
        }
    }
});
