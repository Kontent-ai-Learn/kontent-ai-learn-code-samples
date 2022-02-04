// DocSection: import_rich_create_button_type
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
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
// EndDocSection