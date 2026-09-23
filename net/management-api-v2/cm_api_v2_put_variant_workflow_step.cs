// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.LanguageVariants;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var itemIdentifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// var itemIdentifier = Reference.ByCodename("my_article");
// var itemIdentifier = Reference.ByExternalId("59713");

var languageIdentifier = Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// var languageIdentifier = Reference.ByCodename("es-ES");

var workflowStepIdentifier = Reference.ById(Guid.Parse("16221cc2-bd22-4414-a513-f3e555c0fc93"));

(await client.ChangeLanguageVariantWorkflowAsync(
        new LanguageVariantIdentifier(itemIdentifier, languageIdentifier),
        new ChangeLanguageVariantWorkflowModel(Reference.ByDefaultId(), workflowStepIdentifier)
        {
            DueDate = new DueDateModel
            {
                Value = DateTime.UtcNow.AddDays(42)
            },
            Note = "Make sure the graphic materials we use here are on brand.",
            Contributors = [UserIdentifier.ByEmail("user@example.com")]
        }
        )).EnsureSuccess();
