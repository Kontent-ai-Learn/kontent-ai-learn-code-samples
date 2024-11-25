// DocSection: cm_api_v2_post_create_sutom_app
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var customAppCreateModel = new CustomAppCreateModel
{
    Name = "Custom App Name",
    Codename = "custom_app_codename",
    SourceUrl = "https://customapp.net",
    Config = "{ .. }",
    AllowedRoles = = [
        Reference.ById(Guid.Parse("7740a768-bfa5-4f64-bab4-d77cc0791d4c")),
        Reference.ById(Guid.Parse("7a51d721-7302-4a85-b4ce-a6a3f3cce4a6"))
    ]
};

var response = await client.GetCustomAppAsync(customAppCreateModel);
// EndDocSection