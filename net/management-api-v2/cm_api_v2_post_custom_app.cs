// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var customAppCreateModel = new CustomAppCreateModel
{
    Name = "Custom App Name",
    Codename = "custom_app_codename",
    SourceUrl = "https://customapp.net",
    Config = "{\"theme\":{\"color\":\"#007BFF\",\"logo_url\":\"https://assets.customapp.net/logo.png\"},\"features\":{\"enable_notifications\":true,\"enable_advanced_mode\":false}}",
    AllowedRoles = [
        Reference.ById(Guid.Parse("7740a768-bfa5-4f64-bab4-d77cc0791d4c")),
        Reference.ById(Guid.Parse("7a51d721-7302-4a85-b4ce-a6a3f3cce4a6"))
    ]
};

var response = await client.GetCustomAppAsync(customAppCreateModel);