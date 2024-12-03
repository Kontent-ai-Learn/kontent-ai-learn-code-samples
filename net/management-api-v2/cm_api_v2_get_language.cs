// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("2ea66788-d3b8-5ff5-b37e-258502e4fd5d"));
// var identifier = Reference.ByCodename("de-DE");
// var identifier = Reference.ByExternalId("standard-german");

var response = await client.GetLanguageAsync(identifier);
