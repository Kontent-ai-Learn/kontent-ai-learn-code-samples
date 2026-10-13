// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_SUBSCRIPTION_API_KEY",
    SubscriptionId = "KONTENT_AI_SUBSCRIPTION_ID"
});

var identifier = UserIdentifier.ByEmail("user@kontent.ai");
// var identifier = UserIdentifier.ById("usr_0vKjTCH2TkO687K3y3bKNS");

var response = (await client.GetSubscriptionUserAsync(identifier)).EnsureSuccess();
