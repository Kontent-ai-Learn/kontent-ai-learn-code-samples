// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.AssetFolders;
using Kontent.Ai.Management.Models.AssetFolders.Patch;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.ModifyAssetFoldersAsync(
[
    new AssetFolderAddIntoPatchModel
    {
        Reference = Reference.ByExternalId("folder-with-shared-asset"),
        Value = new AssetFolderHierarchy
        {
            ExternalId = "folder-with-shared-assets",
            Name = "Shared assets",
            Codename = "shared_assets",
        },
        Before = Reference.ByExternalId("folder-with-downloadable-assets")
    },
    new AssetFolderRemovePatchModel
    {
        Reference = Reference.ByExternalId("folder-with-archived-assets")
    },
    new AssetFolderRenamePatchModel
    {
        Reference = Reference.ByCodename("folder_documents"),
        Value = "Legal documents"
    }
])).EnsureSuccess();
