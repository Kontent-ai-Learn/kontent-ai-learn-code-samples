// DocSection: cm_api_v2_post_language
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateLanguageAsync(new LanguageCreateModel
{
    Name = "German (Germany)",
    Codename = "de-DE",
    IsActive = true,
    FallbackLanguage = Reference.ByCodename("de-AT"),
    ExternalId = "standard-german"
});
// EndDocSection