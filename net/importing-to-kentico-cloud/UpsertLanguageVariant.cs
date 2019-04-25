// DocSection: importing-upsert-variant
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "14372844-0a5d-434a-8423-605b8a631623"
};

ContentManagementClient client = new ContentManagementClient(options);

// Elements to update
CafeContentTypeModel stronglyTypedElements = new CafeContentTypeModel
{
    Title = "En Asados",
    Street = "Nove Sady 25",
    City = "Brno",
    Country = "Czech Republic",
    State = "Jihomoravsky kraj",
    ZipCode = "60200",
    Phone = "+420 444 444 444",
    Email = "brnocafe@kentico.com"
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("ext-cafe-brno-59713");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");

ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<CafeContentTypeModel> responseVariant = await client.UpsertContentItemVariantAsync<CafeContentTypeModel>(identifier, stronglyTypedElements);
// EndDocSection