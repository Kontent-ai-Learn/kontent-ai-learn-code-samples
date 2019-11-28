// DocSection: importing_upsert_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using CM API v1
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

// Elements to update
CafeContentTypeModel stronglyTypedElements = new CafeContentTypeModel
{
    Street = "Nove Sady 25",
    City = "Brno",
    Country = "Czech Republic",
    State = "Jihomoravsky kraj",
    ZipCode = "60200",
    Phone = "+420 555 555 555",
    Email = "brnocafe@kontent.ai"
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("ext-cafe-brno");

LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");

ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<CafeContentTypeModel> responseVariant = await client.UpsertContentItemVariantAsync<CafeContentTypeModel>(identifier, stronglyTypedElements);
// EndDocSection