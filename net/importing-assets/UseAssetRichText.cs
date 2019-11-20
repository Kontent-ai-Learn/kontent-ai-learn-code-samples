// DocSection: importing_assets_use_asset_rich_text
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using CM API v1
ArticleModel stronglyTypedElements = new ArticleModel
{
    BodyCopy = @"<p>...</p> <figure data-asset-external-id=\"brno-cafe-image\"></figure>"
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("new-cafes");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<ArticleModel> variantResponse = await client.UpsertContentItemVariantAsync<ArticleModel>(identifier, stronglyTypedElements);
// EndDocSection