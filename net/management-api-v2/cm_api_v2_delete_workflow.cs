// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = Reference.ById(Guid.Parse("f9f28df0-9dec-4ee3-b087-c501e4b75347"));
// var identifier = Reference.ByCodename("my_workflow");

await client.DeleteWorkflowAsync(identifier);
