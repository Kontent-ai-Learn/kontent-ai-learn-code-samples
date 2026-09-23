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

var identifier = Reference.ById(Guid.Parse("3c70b0cc-d9d8-4c9d-a01f-47a2d677fdd5"));
// var identifier = Reference.ByCodename("important_collection");
// var identifier = Reference.ByExternalId("external-collection");

IReadOnlyList<LanguageVariantModel> response = (await client.ListLanguageVariantsByCollectionAsync(identifier)).EnsureSuccess();