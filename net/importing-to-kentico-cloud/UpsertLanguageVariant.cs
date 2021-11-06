// DocSection: importing_upsert_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = new dynamic[]
    {
        new TextElement
        {
            Element = Reference.ByExternalId("street"),
            Value = "Nove Sady 25",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("city"),
            Value = "Brno",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("country"),
            Value = "Czech republic",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("state"),
            Value = "Jihomoravsky kraj",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("zip_code"),
            Value = "60200",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("phone"),
            Value = "+420 555 555 555",
        }.ToDynamic(),
        new TextElement
        {
            Element = Reference.ByExternalId("email"),
            Value = "brnocafe@kontent.ai",
        }.ToDynamic(),
    }
});
// EndDocSection