// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.LanguageVariants;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("b7aa4a53-d9b1-48cf-b7a6-ed0b182c4b89"));
// var identifier = Reference.ByCodename("article");
// var identifier = Reference.ByExternalId("my-article-id");

IReadOnlyList<LanguageVariantModel> response = (await client.ListLanguageVariantsByTypeAsync(identifier)).EnsureSuccess();
