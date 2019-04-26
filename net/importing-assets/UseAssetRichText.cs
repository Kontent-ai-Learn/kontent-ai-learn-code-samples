// DocSection: importing_assets_use_asset_rich_text
// Upsert a language variant which references the asset using external ID
ArticleModel stronglyTypedElements = new ArticleModel
{
    BodyCopy = @"<p>...</p> <figure data-asset-external-id=\"Ext-Asset-Xyz\"></figure>"
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByCodename("new_cafes_joining_our_network_");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<ArticleModel> variantResponse = await client.UpsertContentItemVariantAsync<ArticleModel>(identifier, stronglyTypedElements);
// EndDocSection