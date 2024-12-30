// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CreateWebhookAsync(new WebhookCreateModel
{
    Name = "Example webhook",
    Url = "https://example.com/webhook",
    Secret = "secret_key",
    Headers = new []
    {
        new CustomHeaderModel
        {
            Key = "key1",
            Value = "value1"
        },
        new CustomHeaderModel
        {
            Key = "key2",
            Value = "value2"
        }
    },
    DeliveryTriggers = new DeliveryTriggersModel
    {
        ContentType = new ContentTypeTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
               new ContentTypeActionModel { Action = ContentTypeAction.Created },
               new ContentTypeActionModel { Action = ContentTypeAction.Changed },
               new ContentTypeActionModel { Action = ContentTypeAction.Deleted }
            },
            Filters = new ContentTypeFiltersModel
            {
               ContentTypes = new[] {
                   Reference.ById(Guid.Parse("dd1439d5-4ee2-4895-a4e4-5b0d9d8c754e"))
               }
            }
        },
        ContentItem = new ContentItemTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new ContentItemActionModel
                {
                    Action = ContentItemAction.Deleted,
                    TransitionTo = new []
                    {
                        new ContentItemWorkflowTransition {
                            WorkflowReference = Reference.ById(Guid.Parse("88ac5e6e-1c5c-4638-96e1-0d61221ad5bf")),
                            WorkflowStepReference = Reference.ById(Guid.Parse("b4363ccd-8f21-45fd-a840-5843d7b7f008"))
                        }
                    }
                },
            },
            Filters = new ContentItemFiltersModel
            {
                Languages = new[]
                {
                    Reference.ById(Guid.Parse("1aeb9220-f167-4f8e-a7db-1bfec365fa80"))
                }
            }
        },
        Taxonomy = new TaxonomyTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new TaxonomyActionModel { Action = TaxonomyAction.TermChanged },
                new TaxonomyActionModel { Action = TaxonomyAction.MetadataChanged }
            },
            Filters = new TaxonomyFiltersModel
            {
                Taxonomies = new [] {
                    Reference.ById(Guid.Parse("dd1439d5-4ee2-4895-a4e4-5b0d9d8c754e"))
                }
            }
        },
        Asset = new AssetTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new AssetActionModel { Action = AssetAction.Created },
                new AssetActionModel { Action = AssetAction.Changed }
            }
        },
        Language = new LanguageTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new LanguageActionModel { Action = LanguageAction.Created }
            },
            Filters = new LanguageFiltersModel
            {
                Languages = new [] {
                    Reference.ById(Guid.Parse("1aeb9220-f167-4f8e-a7db-1bfec365fa80"))
                }
            }
        },
        Slot = DeliverySlot.Preview,
        Events = WebhookEvents.Specific
    }
});
