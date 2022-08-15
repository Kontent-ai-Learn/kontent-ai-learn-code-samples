// DocSection: cm_api_v2_put_var_cancel_sched_unpublish
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = new LanguageVariantIdentifier(Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474")), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474")), Reference.ByCodename("es-ES"));
// var identifier = new LanguageVariantIdentifier(Reference.ByCodename("my_article"), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ByCodename("my_article"), Reference.ByCodename("es-ES"));
// var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("59713"), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("59713"), Reference.ByCodename("es-ES"));

await client.CancelUnpublishingOfLanguageVariantAsync(identifier);
// EndDocSection