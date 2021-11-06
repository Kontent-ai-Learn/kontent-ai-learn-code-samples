// DocSection: cm_api_v2_delete_webhook
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("d53360f7-79e1-42f4-a524-1b53a417d03e"));

await client.DeleteWebhookAsync(identifier);
// EndDocSection
