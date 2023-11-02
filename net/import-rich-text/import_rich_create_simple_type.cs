// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
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
