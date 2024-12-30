// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("456"), Reference.ByCodename("en-US"));

await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
    {
        new TextElement
        {
            Element = Reference.ByCodename("title"),
            Value = "Donate with us"
        },
        new LinkedItemsElement
        {
            Element = Reference.ByCodename("related_articles"),
            Value = new []
            {
                Reference.ByExternalId("123"),
            }
        }
    })
});
