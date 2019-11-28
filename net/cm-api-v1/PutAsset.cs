// DocSection: cm_api_v1_put_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

// Note: When creating a new asset, use external ID as an identifier. When updating an asset, you can use internal ID or external ID
AssetIdentifier identifier = AssetIdentifier.ByExternalId("which-brewing-fits-you");
// AssetIdentifier identifier = AssetIdentifier.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));

// Used when creating a new asset or updating an existing one
AssetUpdateModel model = new AssetUpdateModel
{

    Title = "Coffee Brewing Techniques",
  
    Descriptions = new List<AssetDescription> 
    {
        new AssetDescription { Description = "Coffee Brewing Techniques", Language = LanguageIdentifier.ByCodename("en-US") },
        new AssetDescription { Description = "Técnicas para hacer café", Language = LanguageIdentifier.ByCodename("es-ES") }
    }
};

CancellationTokenSource source = new CancellationTokenSource();
byte[] content = await System.IO.File.ReadAllBytesAsync("./which-brewing-fits-you-1080px.jpg", source.Token);
string fileName = "which-brewing-fits-you-1080px.jpg";
string contentType = "image/jpeg";
string externalId = "which-brewing-fits-you";

AssetModel updatedAssetResponse = await client.UpdateAssetAsync(identifier, model);
AssetModel createdAssetResponse = await client.UpsertAssetByExternalIdAsync(externalId, new FileContentSource(content, fileName, contentType), model);
// EndDocSection