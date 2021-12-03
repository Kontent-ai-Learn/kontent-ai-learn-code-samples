// DocSection: importing_assets_create_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
AssetDescription englishDescription = new AssetDescription
{
    Description = "Cafe in Brno",
    Language = LanguageIdentifier.ByCodename("en-US")
};
AssetDescription spanishDescription = new AssetDescription
{
    Description = "Café en Brno",
    Language = LanguageIdentifier.ByCodename("es-ES")
};
IEnumerable<AssetDescription> descriptions = new [] { englishDescription, spanishDescription };

string title = "Brno Cafe";

// Defines the asset to upsert
AssetUpsertModel asset = new AssetUpsertModel
{
    // Uses the file reference object obtained in step 1
    FileReference = fileResult,
    Descriptions = descriptions,
    Title = title
};

string assetExternalId = "brno-cafe-image";

// Upserts an asset by external ID
AssetModel response = await client.UpsertAssetByExternalIdAsync(externalId, asset);
// EndDocSection