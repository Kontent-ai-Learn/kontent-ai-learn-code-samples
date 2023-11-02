// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var client = _fileSystemFixture.CreateMockClientWithResponse("SubscriptionUsers.json");

var response = await client.ListSubscriptionUsersAsync();
