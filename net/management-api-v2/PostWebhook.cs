// DocSection: cm_api_v2_post_webhook
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateWebhookAsync(new WebhookCreateModel
{
    Name = "Example webhook",
    Url = "https://example.com/webhook",
    Secret = "secret_key",
    Triggers = new WebhookTriggersModel
    {
        DeliveryApiContentChanges = new[]
        {
            new DeliveryApiTriggerModel
            {
                Type = TriggerChangeType.LanguageVariant,
                Operations = new []
                {
                    "publish",
                    "unpublish"
                }
            },
            new DeliveryApiTriggerModel
            {
                Type = TriggerChangeType.Taxonomy,
                Operations = new []
                {
                    "archive",
                    "restore",
                    "upsert"
                }
            }
        },
        PreviewDeliveryApiContentChanges = new[]
        {
            new DeliveryApiTriggerModel
            {
                Type = TriggerChangeType.LanguageVariant,
                Operations = new []
                {
                    "archive",
                    "upsert"
                }
            },
            new DeliveryApiTriggerModel
            {
                Type = TriggerChangeType.Taxonomy,
                Operations = new []
                {
                    "archive",
                    "restore",
                    "upsert"
                }
            }
        },
        WorkflowStepChanges = new[]
        {
            new WorkflowStepTriggerModel
            {
                TransitionsTo = new []
                {
                    Reference.ById(Guid.Parse("b4363ccd-8f21-45fd-a840-5843d7b7f008")),
                    Reference.ById(Guid.Parse("88ac5e6e-1c5c-4638-96e1-0d61221ad5bf")),
                }
            },
        },
        ManagementApiContentChanges = new[]
        {
            new ManagementApiTriggerModel
            {
                Operations = new []
                {
                    "archive",
                    "create",
                    "restore",
                }
            }
        },
    }
});

// EndDocSection