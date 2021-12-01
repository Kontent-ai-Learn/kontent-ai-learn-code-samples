// DocSection: import_model_create_snippet
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateContentTypeSnippetAsync(new CreateContentSnippetCreateModel
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
