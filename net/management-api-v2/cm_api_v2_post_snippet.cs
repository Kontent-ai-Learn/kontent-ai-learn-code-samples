// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateContentTypeSnippetAsync(new ContentTypeSnippetCreateModel
{
    Name = "metadata",
    Codename = "my_metadata",
    ExternalId = "snippet-item-123",
    Elements = new ElementMetadataBase[]
    {
        new TextElementMetadataModel
        {
            Name = "Meta title",
            Codename = "my_metadata__meta_title",
            Guidelines = "Length: 30-60 characters",
            ExternalId = "meta_title",
        },
        new TextElementMetadataModel
        {
            Name = "Meta description",
            Codename = "my_metadata__meta_description",
            Guidelines = "Length: 70-11500 characters",
            ExternalId = "meta_description",
        }
    }
});
