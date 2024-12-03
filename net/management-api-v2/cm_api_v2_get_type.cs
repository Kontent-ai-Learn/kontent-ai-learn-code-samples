// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("269202ad-1d9d-47fd-b3e8-bdb05b3e3cf0"));
// var identifier = Reference.ByCodename("new_article");
// var identifier = Reference.ByExternalId("article");

var response = await client.GetContentTypeAsync(identifier);
