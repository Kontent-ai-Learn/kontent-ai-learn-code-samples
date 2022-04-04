// DocSection: cm_api_v2_put_variant_workflow_step
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var itemIdentifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// var itemIdentifier = Reference.ByCodename("my_article");
// var itemIdentifier = Reference.ByExternalId("59713");

var languageIdentifier = Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// var languageIdentifier = Reference.ByCodename("es-ES");

var workflowStepIdentifier = Reference.ById(Guid.Parse("16221cc2-bd22-4414-a513-f3e555c0fc93"));

await client.ChangeLanguageVariantWorkflowAsync(
    new LanguageVariantIdentifier(itemIdentifier, languageIdentifier),
    new WorkflowStepIdentifier(Reference.ById(Guid.Empty), workflowStepIdentifier)));
// EndDocSection