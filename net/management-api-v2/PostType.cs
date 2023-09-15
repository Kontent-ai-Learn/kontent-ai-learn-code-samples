// DocSection: cm_api_v2_post_type
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateContentTypeAsync(new ContentTypeCreateModel
{
    ExternalId = "article",
    Name = "Article",
    Codename = "my_article",
    ContentGroups = new[]
    {
        new ContentGroupModel
        {
            Name = "Article Copy",
            ExternalId = "article-copy",
        },
        new ContentGroupModel
        {
            Name = "Author",
            CodeName = "author",
        }
    },
    Elements = new ElementMetadataBase[]
    {
        new TextElementMetadataModel
        {
            Name = "Article title",
            Codename = "title",
            ContentGroup = Reference.ByCodename("article-copy"),
            DefaultValue = new TextElementDefaultValueModel
            {
                Global = new TypeValue<string>()
                {
                    Value = "This is the default value of the text element."
                }
            }
        },
        new RichTextElementMetadataModel
        {
            Name = "Article body",
            Codename = "body",
            ContentGroup = Reference.ByCodename("article-copy"),
        },
        new RichTextElementMetadataModel
        {
            Name = "Author bio",
            Codename = "bio",
            AllowedBlocks = new HashSet<RichTextBlockType>()
            {
                RichTextBlockType.Images,
                RichTextBlockType.Text
            },
            ContentGroup = Reference.ByCodename("author"),
        },
    }
});
// EndDocSection
