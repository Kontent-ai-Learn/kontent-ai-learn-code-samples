// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.LanguageVariants;
using Kontent.Ai.Management.Models.LanguageVariants.Elements;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("456"), Reference.ByCodename("en-US"));

(await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements =
    [
        new TextElement { Element = Reference.ByCodename("title"), Value = "Donate with us" },
        new LinkedItemsElement
        {
            Element = Reference.ByCodename("related_articles"),
            Value = [Reference.ByExternalId("123")],
        },
    ]
})).EnsureSuccess();
