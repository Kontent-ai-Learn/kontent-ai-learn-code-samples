// DocSection: import_rich_create_simple_type
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    Name = "Simple Rich Text",
    Codename = "simple-rich-text",
    Elements = new ElementMetadataBase[]
    {
        new RichTextElementMetadataModel
        {
            Name = "Rich Text",
            ExternalId = "rich-text",
        },
    }
});
// EndDocSection