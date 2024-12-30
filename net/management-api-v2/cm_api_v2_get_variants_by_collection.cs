// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("3c70b0cc-d9d8-4c9d-a01f-47a2d677fdd5"));
// var identifier = Reference.ByCodename("important_collection");
// var identifier = Reference.ByExternalId("external-collection");

// Gets the first page of results
var response = await client.ListLanguageVariantsByCollectionAsync(identifier);