// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
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
    },
    new ContentTypeMovePatchModel
    {
        Path = "/elements/codename:my_text_element",
        After = Reference.ByExternalId("my-title-id")
    },
    new ContentTypeMovePatchModel
    {
        Path = "/elements/external_id:my-multiple-choice-id/options/id:d66ffa49-86ff-eeaa-c33b-e5d9eefe8b81",
        Before = Reference.ById(Guid.Parse("523e6231-8d80-a158-3601-dffde4e64a78"))
    }
});
