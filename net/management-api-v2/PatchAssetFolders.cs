// DocSection: cm_api_v2_patch_asset_folders
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
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
            Folders = Enumerable.Empty<AssetFolderHierarchy>(),
        },
        Before = Reference.ByExternalId("folder-with-downloadable-assets")
    },
    new AssetFolderRemoveModel
    {
        Reference = Reference.ByExternalId("folder-with-archived-assets")
    },
    new AssetFolderRenameModel
    {
        Reference = Reference.ByExternalId("folder-documents"),
        Value = "Legal documents"
    }
});
// EndDocSection
