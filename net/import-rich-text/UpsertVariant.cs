// DocSection: import_rich_upsert_variant
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("simple-example"), Reference.ById(Guid.Parse("00000000-0000-0000-0000-000000000000")));

await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
    {
        new RichTextElement
        {
            Element = Reference.ByExternalId("rich-text"),
            Value = "<h1>Lorem Ipsum</h1>\n<p>Lorem ipsum dolor sit amet, consectetur <a href=\"https://wikipedia.org\">adipiscing elit</a>, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>\n<object type=\"application/kenticocloud\" data-type=\"component\" data-id=\"a2ee7bac-15ff-4dce-a244-012b9f98dd7b\"></object>\n<p>Ut enim ad minim veniam, <a data-item-external-id=\"second-page\">quis nostrud</a> exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>\n<ul>\n  <li>Lorem ipsum dolor sit amet</li>\n  <li>Consectetur adipiscing elit</li>\n  <li>Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</li>\n</ul><figure data-asset-external-id=\"rich-text-asset\"></figure>",
            Components = new ComponentModel[]
            {
                new ComponentModel
                {
                    Id = Guid.Parse("a2ee7bac-15ff-4dce-a244-012b9f98dd7b"),
                    Type = Reference.ByExternalId("button"),
                    Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
                    {
                        new TextElement
                        {
                            Element = Reference.ByExternalId("button-text"),
                            Value = "Buy me",
                        },
                        new TextElement
                        {
                            Element = Reference.ByExternalId("button-link"),
                            Value = "https://kontent.ai",
                        }
                    })
                }
            }
        }.ToDynamic(),
    }),
});
// EndDocSection