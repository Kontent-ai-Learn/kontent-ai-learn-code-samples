// DocSection: cm_api_v1_delete_variant
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByCodename("on_roasts");
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("59713");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("es-ES");

ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

await client.DeleteContentItemVariantAsync(identifier);
// EndDocSection