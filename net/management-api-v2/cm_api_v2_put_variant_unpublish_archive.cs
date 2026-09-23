// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.LanguageVariants;
using Kontent.Ai.Management.Models.Publishing;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = LanguageVariantIdentifier.ByIds(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"), Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8"));
// var identifier = LanguageVariantIdentifier.ByCodenames("my_article", "es-ES");

// Immediate unpublish
(await client.UnpublishLanguageVariantAsync(identifier)).EnsureSuccess();

// Scheduled unpublish
(await client.ScheduleUnpublishingOfLanguageVariantAsync(identifier, new ScheduleModel
{
    ScheduledTo = new DateTimeOffset(2038, 1, 19, 4, 14, 8, TimeSpan.Zero),
    DisplayTimeZone = "Australia/Sydney"
})).EnsureSuccess();
