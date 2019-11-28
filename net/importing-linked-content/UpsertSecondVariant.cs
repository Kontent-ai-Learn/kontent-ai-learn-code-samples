// DocSection: import_linked_upsert_Sec_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using CM API v1
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ArticleModel stronglyTypedElements = new ArticleModel
{
    Title = "Donate with us",
    RelatedArticles = new [] { ContentItemIdentifier.ByExternalId("123") }
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("456");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<ArticleModel> responseVariant = await client.UpsertContentItemVariantAsync<ArticleModel>(identifier, stronglyTypedElements);
// EndDocSection