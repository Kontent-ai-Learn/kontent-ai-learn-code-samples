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
    DeliveryTriggers = new DeliveryTriggersModel
    {
        ContentType = new ContentTypeTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
               new ContentTypeActionModel { Action = ContentTypeActionEnum.Created },
               new ContentTypeActionModel { Action = ContentTypeActionEnum.Changed },
               new ContentTypeActionModel { Action = ContentTypeActionEnum.Deleted }
            }
        },
        ContentItem = new ContentItemTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new ContentItemActionModel
                {
                    Action = ContentItemActionEnum.Deleted,
                    TransitionTo = new []
                    {
                        new WorkflowApiReference {
                            WorkflowReference = Reference.ById(Guid.Parse("88ac5e6e-1c5c-4638-96e1-0d61221ad5bf")),
                            WorkflowStepReference = Reference.ById(Guid.Parse("b4363ccd-8f21-45fd-a840-5843d7b7f008"))
                        }
                    }
                }
            },
            Filters = new ContentItemFiltersModel
            {
                Languages = new []
                {
                    Reference.ById(Guid.Parse("b4363ccd-8f21-45fd-a840-5843d7b7f008"))
                }
            }
        },
        Taxonomy = new TaxonomyTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new TaxonomyActionModel { Action = TaxonomyActionEnum.TermChanged },
                new TaxonomyActionModel { Action = TaxonomyActionEnum.MetadataChanged }
            }
        },
        Asset = new AssetTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new AssetActionModel { Action = AssetActionEnum.Created },
                new AssetActionModel { Action = AssetActionEnum.Changed }
            }
        },
        Language = new LanguageTriggerModel
        {
            Enabled = true,
            Actions = new []
            {
                new LanguageActionModel { Action = LanguageActionEnum.Created }
            }
        },
        Slot = DeliverySlotModel.Published,
        Events =  WebhookEventsFilterModel.Specific
    }
});
