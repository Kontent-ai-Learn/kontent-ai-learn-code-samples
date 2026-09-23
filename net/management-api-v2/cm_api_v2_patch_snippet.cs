// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.TypeSnippets.Patch;
using Kontent.Ai.Management.Models.Types.Elements;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("baf884be-531f-441f-ae88-64205efdd0f6"));
// var identifier = Reference.ByCodename("my_metadata_snippet");
// var identifier = Reference.ByExternalId("my-metadata-snippet-id");

var response = (await client.ModifyContentTypeSnippetAsync(identifier,
[
    ContentTypeSnippetPatch.ReplaceName("A new snippet name"),
    ContentTypeSnippetPatch.ReplaceGuidelines(
        Reference.ByCodename("my_metadata__my_meta_description"),
        "Length: 70-150 characters."),
    ContentTypeSnippetPatch.AddElement(new TextElementMetadataModel
    {
        Name = "My meta title",
        Guidelines = "Length: 30–60 characters.",
        ExternalId = "my-meta-title-id"
    }),
    ContentTypeSnippetPatch.RemoveElement(Reference.ById(Guid.Parse("0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"))),
    ContentTypeSnippetPatch.RemoveOption(
        Reference.ByExternalId("my-multiple-choice-id"),
        Reference.ByCodename("my_option")),
    ContentTypeSnippetPatch.MoveElementAfter(
        Reference.ByCodename("my_metadata_snippet__my_meta_title"),
        Reference.ByCodename("my_metadata_snippet__my_meta_description")),
    ContentTypeSnippetPatch.MoveOptionBefore(
        Reference.ByExternalId("my-multiple-choice-id"),
        Reference.ById(Guid.Parse("8e6ec8b1-6510-4b9b-b4be-6c977f4bdfbc")),
        Reference.ById(Guid.Parse("6bfe5a60-5cc2-4303-8f72-9cc53431046b")))
])).EnsureSuccess();
