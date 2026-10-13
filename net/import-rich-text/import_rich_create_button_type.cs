// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Types;
using Kontent.Ai.Management.Models.Types.Elements;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    ExternalId = "button",
    Name = "Button",
    Elements =
    [
        new TextElementMetadataModel
        {
            Name = "Text",
            ExternalId = "button-text",
        },
        new TextElementMetadataModel
        {
            Name = "Link",
            ExternalId = "button-link",
        },
    ]
})).EnsureSuccess();
