// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Languages.Patch;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("2ea66788-d3b8-5ff5-b37e-258502e4fd5d"));
// var identifier = Reference.ByCodename("de-DE");
// var identifier = Reference.ByExternalId("standard-german");


var response = (await client.ModifyLanguageAsync(identifier,
[
    LanguagePatch.FallbackLanguage(Reference.ByCodename("en-US")),
    LanguagePatch.Name("Deutsch"),
])).EnsureSuccess();
