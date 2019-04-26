// DocSection: import_linked_upsert_variant
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "14372844-0a5d-434a-8423-605b8a631623"
};

ContentManagementClient client = new ContentManagementClient(options);

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