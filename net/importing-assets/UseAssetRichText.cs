// DocSection: importing_assets_use_asset_rich_text
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("new-cafes"), Reference.ByCodename("en-US"));

var response = await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = new dynamic[]
    {
        new RichTextElement
        {
            Element = Reference.ByCodename("body_copy"),
            Value = "<p>...</p> <figure data-asset-external-id=\"brno-cafe-image\"></figure>",
        }.ToDynamic()
    }
});
// EndDocSection