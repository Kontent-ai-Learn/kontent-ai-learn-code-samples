// DocSection: cm_api_v2_post_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;
 
ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

AssetUpsertModel model = new AssetUpsertModel
{
    // To create a file reference, see the "Upload a binary file" endpoint
    FileReference = fileReference,

    Title = "Coffee Brewing Techniques",
  
    Descriptions = new List<AssetDescription> 
    {
        new AssetDescription { Description = "Coffee Brewing Techniques", Language = LanguageIdentifier.ByCodename("en-US") },
        new AssetDescription { Description = "Técnicas para hacer café", Language = LanguageIdentifier.ByCodename("es-ES") }
    }
};

AssetModel assetResult = await client.CreateAssetAsync(model);
// EndDocSection