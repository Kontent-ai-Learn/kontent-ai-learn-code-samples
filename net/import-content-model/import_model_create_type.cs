// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.Types;
using Kontent.Ai.Management.Models.Types.Elements;
using Kontent.Ai.Management.Models.Types.Elements.DefaultValues;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    Name = "Blogpost",
    Codename = "blogpost",
    ContentGroups =
    [
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
    ],
    Elements =
    [
        new TextElementMetadataModel
        {
            Name = "Title",
            ContentGroup = Reference.ByExternalId("content"),
            DefaultValue = new TextElementDefaultValueModel("This is the default value of the text element.")
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
            Snippet = Reference.ByCodename("metadata"),
            Codename = "metadata",
            ContentGroup = Reference.ByExternalId("metadata")
        },
        new TaxonomyElementMetadataModel
        {
            TaxonomyGroup = Reference.ByCodename("blog_topic"),
            Codename = "taxonomy",
            ContentGroup = Reference.ByExternalId("topic")
        }
    ]
})).EnsureSuccess();
