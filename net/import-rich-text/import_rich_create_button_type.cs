// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    ExternalId = "button",
    Name = "Button",
    Elements = new ElementMetadataBase[]
    {
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
    }
});
