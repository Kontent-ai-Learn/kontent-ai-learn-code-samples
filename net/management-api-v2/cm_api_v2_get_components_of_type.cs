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

var identifier = Reference.ById(Guid.Parse("6434e475-5a29-4866-9fd1-6d1ca873f5be"));
// var identifier = Reference.ByCodename("article");
// var identifier = Reference.ByExternalId("my-article-id");

IReadOnlyList<LanguageVariantModel> response = (await client.ListLanguageVariantsOfContentTypeWithComponentsAsync(identifier)).EnsureSuccess();
