// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
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
