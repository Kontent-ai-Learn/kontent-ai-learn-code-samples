// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("6434e475-5a29-4866-9fd1-6d1ca873f5be"));
// var identifier = Reference.ByCodename("article");
// var identifier = Reference.ByExternalId("my-article-id");

// Gets the first page of results
var response = await client.ListLanguageVariantsOfContentTypeWithComponentsAsync(identifier);
