// DocSection: cm_api_v2_patch_type
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("my_article");
// var identifier = Reference.ByExternalId("my-article-id");

var response = await client.ModifyContentTypeAsync(identifier, new ContentTypeOperationBaseModel[]
{
    new ContentTypeReplacePatchModel
    {
        Path = "/name",
        Value = "A new type name"
    },
    new ContentTypeReplacePatchModel
    {
        Path = "/elements/codename:my_text_element/guidelines",
        Value = "Here you can tell users how to fill in the element."
    },
    new ContentTypeAddIntoPatchModel
    {
        Path = "/elements",
        Value = new TextElementMetadataModel
        {
            Name = "My title",
            Guidelines = "Title of the article in plain text.",
            ExternalId = "my-title-id",
        },
    },
    new ContentTypeRemovePatchModel
    {
        Path = "/elements/id:0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"
    }
});
// EndDocSection