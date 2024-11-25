// DocSection: cm_api_v2_patch_modify_custom_app
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var changes = new CustomAppOperationBaseModel[]
{
    new CustomAppAddIntoPatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("new_allowed_role_codename_to_be_add_into")
        }
    },
    new CustomAppRemovePatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("allowed_role_codename_to_be_removed")
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
        Value = "{ .. }"
    },
    new CustomAppReplacePatchModel()
    {
        PropertyName = PropertyName.AllowedRoles,
        Value = new[]
        {
            Reference.ByCodename("allowed_role_codename"),
            Reference.ById(new Guid("f8f0b5cb-f5b7-42e8-af85-fbdab3ddfacf"))
        }
    }
};

var response = await client.ModifyCustomAppAsync(customAppCreateModel);
// EndDocSection