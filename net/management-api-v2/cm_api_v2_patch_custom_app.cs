// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
//var identifier = Reference.ByCodename("my_custom_app");

var changes = new CustomAppOperationBaseModel[]
{
    new CustomAppAddIntoPatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("new_allowed_role_codename_to_add")
        }
    },
    new CustomAppRemovePatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("allowed_role_codename_to_remove")
        }
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.Name,
        Value = "New Custom App Name"
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.Codename,
        Value = "new_custom_app_codename"
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.SourceUrl,
        Value = "https://newcustomapplication.net"
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.Config,
        Value = null
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("allowed_role_codename"),
            Reference.ById(new Guid("f8f0b5cb-f5b7-42e8-af85-fbdab3ddfacf"))
        }
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.DisplayMode,
        Value = CustomAppDisplayMode.Dialog
    }
};

var response = await client.ModifyCustomAppAsync(identifier, customAppCreateModel);