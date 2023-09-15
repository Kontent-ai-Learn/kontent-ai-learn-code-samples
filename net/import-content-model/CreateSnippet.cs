// DocSection: import_model_create_snippet
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateContentTypeSnippetAsync(new ContentTypeSnippetCreateModel
{
    Name = "Metadata",
    Codename = "metadata",
    Elements = new ElementMetadataBase[]
    {
        new TextElementMetadataModel
        {
            Name = "Title",
            Codename = "title",
        },
        new TextElementMetadataModel
        {
            Name = "Keywords",
            Codename = "keywords",
        },
        new TextElementMetadataModel
        {
            Name = "Description",
            Codename = "description",
        },
    }
});
// EndDocSection
