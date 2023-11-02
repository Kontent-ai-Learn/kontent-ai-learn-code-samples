// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateLanguageAsync(new LanguageCreateModel
{
    Name = "German (Germany)",
    Codename = "de-DE",
    IsActive = true,
    FallbackLanguage = Reference.ByCodename("de-AT"),
    ExternalId = "standard-german"
});
