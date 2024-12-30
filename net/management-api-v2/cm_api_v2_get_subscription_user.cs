// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = UserIdentifier.ByEmail("Joe.Joe@kontent.ai");
//var identifier = UserIdentifier.ById("usr_0vKjTCH2TkO687K3y3bKNS");

var response = await client.GetSubscriptionUserAsync(identifier);
