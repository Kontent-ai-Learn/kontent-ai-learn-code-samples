// DocSection: importing_upsert_variant
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
    {
        new TextElement
        {
            Element = Reference.ByExternalId("street"),
            Value = "Nove Sady 25",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("city"),
            Value = "Brno",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("country"),
            Value = "Czech republic",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("state"),
            Value = "Jihomoravsky kraj",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("zip_code"),
            Value = "60200",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("phone"),
            Value = "+420 555 555 555",
        },
        new TextElement
        {
            Element = Reference.ByExternalId("email"),
            Value = "brnocafe@kontent.ai",
        },
    })
});
// EndDocSection