// DocSection: importing_assets_use_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});
var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("ext-cafe-brno"), Reference.ByCodename("en-US"));

var response = await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
    {
        new AssetElement
        {
            Element = Reference.ByCodename("photo"),
            Value = new[]
            {
                Reference.ByExternalId("brno-cafe-image")
            }
        }
    })
});
// EndDocSection