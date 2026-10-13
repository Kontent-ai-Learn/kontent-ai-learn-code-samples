// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("baf884be-531f-441f-ae88-64205efdd0f6"));
// var identifier = Reference.ByCodename("metadata");
// var identifier = Reference.ByExternalId("snippet-type-123");

(await client.DeleteContentTypeSnippetAsync(identifier)).EnsureSuccess();
