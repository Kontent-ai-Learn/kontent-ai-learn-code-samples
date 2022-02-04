// DocSection: cm_api_v2_patch_snippet
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("baf884be-531f-441f-ae88-64205efdd0f6"));
// var identifier = Reference.ByCodename("my_metadata_snippet");
// var identifier = Reference.ByExternalId("my-metadata-snippet-id");

var response = await client.ModifyContentTypeSnippetAsync(identifier, new ContentTypeSnippetOperationBaseModel[]
{
    new ContentTypeSnippetPatchReplaceModel
    {
        Path = "/name",
        Value = "A new snippet name"
    },
    new ContentTypeSnippetPatchReplaceModel
    {
        Path = "/elements/codename:my_metadata__my_meta_description/guidelines",
        Value = "Length: 70-150 characters."
    },
    new ContentTypeSnippetAddIntoPatchModel
    {
        Path = "/elements",
        Value = new TextElementMetadataModel
        {
            Name = "My meta title",
            Guidelines = "Length: 30–60 characters.",
            ExternalId = "my-meta-title-id"
        },
    },
    new SnippetPatchRemoveModel
    {
        Path = "/elements/id:0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"
    },
    new SnippetPatchRemoveModel
    {
        Path = "/elements/external_id:my-multiple-choice-id/options/codename:my_option"
    }
});
// EndDocSection