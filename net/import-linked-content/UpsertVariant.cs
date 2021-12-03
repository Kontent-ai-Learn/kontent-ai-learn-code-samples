// DocSection: import_linked_upsert_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ArticleModel stronglyTypedElements = new ArticleModel
{
    Title = "On Roasts",
    RelatedArticles = new [] { ContentItemIdentifier.ByExternalId("456") }
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("123");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<ArticleModel> responseVariant = await client.UpsertContentItemVariantAsync<ArticleModel>(identifier, stronglyTypedElements);
// EndDocSection