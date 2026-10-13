// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.AssetFolders;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.CreateAssetFoldersAsync(new AssetFolderCreateModel
{
    Folders =
    [
        new AssetFolderHierarchy
        {
            Name = "Top level folder",
            ExternalId = "top-folder",
            Codename = "top_folder",
            Folders =
            [
                new AssetFolderHierarchy
                {
                    Name = "Second level folder",
                    ExternalId = "second-folder",
                }
            ]
        }
    ]
})).EnsureSuccess();
