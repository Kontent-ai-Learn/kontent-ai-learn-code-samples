// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.CustomApps;
using Kontent.Ai.Management.Models.CustomApps.Patch;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// var identifier = Reference.ByCodename("my_custom_app");

var response = (await client.ModifyCustomAppAsync(identifier,
[
    CustomAppPatch.AddAllowedRole(Reference.ByCodename("new_allowed_role_codename_to_add")),
    CustomAppPatch.RemoveAllowedRole(Reference.ByCodename("allowed_role_codename_to_remove")),
    CustomAppPatch.ReplaceName("New Custom App Name"),
    CustomAppPatch.ReplaceCodename("new_custom_app_codename"),
    CustomAppPatch.ReplaceSourceUrl("https://newcustomapplication.net"),
    CustomAppPatch.ReplaceConfig(null),
    CustomAppPatch.ReplaceAllowedRoles(
        Reference.ByCodename("allowed_role_codename"),
        Reference.ById(Guid.Parse("f8f0b5cb-f5b7-42e8-af85-fbdab3ddfacf"))),
    CustomAppPatch.ReplaceDisplayMode(CustomAppDisplayMode.Dialog),
])).EnsureSuccess();