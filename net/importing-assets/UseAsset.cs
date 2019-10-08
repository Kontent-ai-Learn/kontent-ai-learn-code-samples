// DocSection: importing_assets_use_asset
// Using CM API v1
// Upsert a language variant which references the asset using external ID
CafeModel stronglyTypedElements = new CafeModel
{
    Picture = AssetIdentifier.ByExternalId("Ext-Asset-Xyz"),
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("ext-cafe-brno-59713");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<CafeModel> variantResponse = await client.UpsertContentItemVariantAsync<CafeModel>(identifier, stronglyTypedElements);
// EndDocSection