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
    ExternalId = "article",
    Name = "Article",
    Codename = "my_article",
    ContentGroups =
    [
        new ContentGroupModel
        {
            Name = "Article Copy",
            ExternalId = "article-copy",
        },
        new ContentGroupModel
        {
            Name = "Author",
            Codename = "author",
        }
    ],
    Elements =
    [
        new TextElementMetadataModel
        {
            Name = "Article title",
            Codename = "title",
            ContentGroup = Reference.ByExternalId("article-copy"),
            DefaultValue = new TextElementDefaultValueModel("This is the default value of the text element.")
        },
        new RichTextElementMetadataModel
        {
            Name = "Article body",
            Codename = "body",
            ContentGroup = Reference.ByExternalId("article-copy"),
        },
        new RichTextElementMetadataModel
        {
            Name = "Author bio",
            Codename = "bio",
            AllowedBlocks = [RichTextBlockType.Images, RichTextBlockType.Text],
            ContentGroup = Reference.ByCodename("author"),
        },
    ]
})).EnsureSuccess();
