// DocSection: cm_api_v2_delete_type
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("269202ad-1d9d-47fd-b3e8-bdb05b3e3cf0"));
// var identifier = Reference.ByCodename("hosted_video");
// var identifier = Reference.ByExternalId("Content-Type-123");

await client.DeleteContentTypeAsync(identifier);
// EndDocSection