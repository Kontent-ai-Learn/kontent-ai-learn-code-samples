// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CreateAssetFoldersAsync(new AssetFolderCreateModel
{
    Folders = new[]
    {
        new AssetFolderHierarchy
        {
            Name = "Top level folder",
            ExternalId = "top-folder",
            Codename = "top_folder",
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
