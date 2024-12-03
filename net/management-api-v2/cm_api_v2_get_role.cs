// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("a23d3727-3b16-4d94-9eb0-85225d29cfef"));
//var identifier = Reference.ByCodename("project-manager");

var response = await client.GetProjectRoleAsync(identifier);
