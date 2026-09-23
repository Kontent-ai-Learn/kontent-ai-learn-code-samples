// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_SUBSCRIPTION_API_KEY",
    SubscriptionId = "KONTENT_AI_SUBSCRIPTION_ID"
});

var count = (await client.ListSubscriptionProjectsAsync()).EnsureSuccess().Count;
