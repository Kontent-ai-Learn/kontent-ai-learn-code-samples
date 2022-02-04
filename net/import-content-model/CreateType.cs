// DocSection: import_model_create_type
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    Name = "Blogpost",
    Codename = "blogpost",
    ContentGroups = new[]
    {
        new ContentGroupModel
        {
            Name = "Content",
            ExternalId = "content",
        },
        new ContentGroupModel
        {
            Name = "Metadata",
            ExternalId = "metadata",
        },
        new ContentGroupModel
        {
            Name = "Topic",
            ExternalId = "topic",
        }
    },
    Elements = new ElementMetadataBase[]
    {
        new TextElementMetadataModel
        {
            Name = "Title",
            ContentGroup = Reference.ByExternalId("content")
        },
        new AssetElementMetadataModel
        {
            Name = "Image",
            ContentGroup = Reference.ByExternalId("content")
        },
        new RichTextElementMetadataModel
        {
            Name = "Blog content",
            ContentGroup = Reference.ByExternalId("content")
        },
        new ContentTypeSnippetElementMetadataModel
        {
            SnippetIdentifier = Reference.ByCodename("metadata"),
            Codename = "metadata",
            ContentGroup = Reference.ByExternalId("metadata")
        },
        new TaxonomyElementMetadataModel
        {
            TaxonomyGroup = Reference.ByExternalId("blog_topic"),
            Codename = "taxonomy",
            ContentGroup = Reference.ByExternalId("topic")
        }
    }
});
// EndDocSection
