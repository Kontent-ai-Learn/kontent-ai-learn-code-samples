// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Languages;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.CreateLanguageAsync(new LanguageCreateModel
{
    Name = "German (Germany)",
    Codename = "de-DE",
    IsActive = true,
    FallbackLanguage = Reference.ByCodename("de-AT"),
    ExternalId = "standard-german"
})).EnsureSuccess();
