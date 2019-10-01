// DocSection: cm_api_v1_put_variant
ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

// Elements to update
MyContentTypeModel stronglyTypedElements = new MyContentTypeModel
{
    Title = "En Asados",
    PostDate = new DateTime(2014, 11, 7),
    Summary = "Tostar granos de café puede tardar de 6 a 13 minutos. ...",
    RelatedArticles = new [] { ContentItemIdentifier.ByCodename("coffee_processing_techniques"), ContentItemIdentifier.ByCodename("origins_of_arabica_bourbon") },
    UrlPattern = "on-roasts",
    MetaKeywords = "asados, café",
    MetaDescription = "Tostar granos de café puede tardar de 6 a 13 minutos. ...",
    Personas = new [] { TaxonomyTermIdentifier.ByCodename("barista"), TaxonomyTermIdentifier.ByCodename("coffee_blogger") }
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByCodename("on_roasts");
// ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("59713");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("es-ES");


ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<MyContentTypeModel> responseVariant = await client.UpsertContentItemVariantAsync<MyContentTypeModel>(identifier, stronglyTypedElements);
// EndDocSection