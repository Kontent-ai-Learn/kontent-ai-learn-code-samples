// DocSection: cm_api_v2_get_subscription_user
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = UserIdentifier.ByEmail("Joe.Joe@kentico.com");
//var identifier = UserIdentifier.ById("usr_0vKjTCH2TkO687K3y3bKNS");

var response = await client.GetSubscriptionUserAsync(identifier);
// EndDocSection
