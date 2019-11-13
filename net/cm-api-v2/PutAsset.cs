// DocSection: cm_api_v2_put_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

// Note: When creating a new asset, use external ID as an identifier. When updating an asset, you can use internal ID or external ID
AssetIdentifier identifier = AssetIdentifier.ByExternalId("which-brewing-fits-you");
// AssetIdentifier identifier = AssetIdentifier.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));

// Used when updating an existing asset
AssetUpdateModel updateModel = new AssetUpdateModel
{

    Title = "Coffee Brewing Techniques",
  
    Descriptions = new List<AssetDescription> 
    {
        new AssetDescription { Description = "Coffee Brewing Techniques", Language = LanguageIdentifier.ByCodename("en-US") },
        new AssetDescription { Description = "Técnicas para hacer café", Language = LanguageIdentifier.ByCodename("es-ES") }
    }
};

// Used when creating a new asset or updating an existing one
AssetUpsertModel upsertModel = new AssetUpsertModel
{
    // 'fileReference' is only required when creating a new asset
    // To create a file reference, see the "Upload a binary file" endpoint
    FileReference = fileReference,

    Title = "Coffee Brewing Techniques",
  
    Descriptions = new List<AssetDescription>
    {
        new AssetDescription { Description = "Coffee Brewing Techniques", Language = LanguageIdentifier.ByCodename("en-US") },
        new AssetDescription { Description = "Técnicas para hacer café", Language = LanguageIdentifier.ByCodename("es-ES") }
    }
};

AssetModel updatedAssetResponse = await client.UpdateAssetAsync(identifier, updateModel);
AssetModel createdAssetResponse = await client.UpsertAssetByExternalIdAsync(identifier, upsertModel);
// EndDocSection