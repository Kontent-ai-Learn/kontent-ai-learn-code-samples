// DocSection: cm_api_v2_get_snippet
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("baf884be-531f-441f-ae88-64205efdd0f6"));
// var identifier = Reference.ByCodename("metadata");
// var identifier = Reference.ByExternalId("snippet-type-123");

var response = await client.GetContentTypeSnippetAsync(identifier);
// EndDocSection