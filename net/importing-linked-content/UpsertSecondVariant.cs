// DocSection: import_linked_upsert_Sec_variant
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("456"), Reference.ByCodename("en-US"));

await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = new dynamic[]
    {
        new TextElement
        {
            Element = Reference.ByCodename("title"),
            Value = "Donate with us"
        }.ToDynamic(),
        new LinkedItemsElement
        {
            Element = Reference.ByCodename("related_articles"),
            Value = new []
            {
                Reference.ByExternalId("123"),
            }
        }.ToDynamic()
    }
});
// EndDocSection