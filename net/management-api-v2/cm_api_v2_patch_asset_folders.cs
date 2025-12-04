// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.ModifyAssetFoldersAsync(new AssetFolderOperationBaseModel[]
{
    new AssetFolderAddIntoModel
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
    new AssetFolderRemoveModel
    {
        Reference = Reference.ByExternalId("folder-with-archived-assets")
    },
    new AssetFolderRenameModel
    {
        Reference = Reference.ByCodename("folder_documents"),
        Value = "Legal documents"
    }
});
