// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.Types.Elements;
using Kontent.Ai.Management.Models.Types.Elements.DefaultValues;
using Kontent.Ai.Management.Models.Types.Patch;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("my_article");
// var identifier = Reference.ByExternalId("my-article-id");

var response = (await client.ModifyContentTypeAsync(identifier,
[
    ContentTypePatch.ReplaceName("A new type name"),
    ContentTypePatch.ReplaceGuidelines(
        Reference.ByCodename("my_text_element"),
        "Here you can tell users how to fill in the element."),
    ContentTypePatch.ReplaceDefault(
        Reference.ByCodename("my_text_element"),
        new TextElementDefaultValueModel("This is a default value of the text element.")),
    ContentTypePatch.AddElement(new TextElementMetadataModel
    {
        Name = "My title",
        Guidelines = "Title of the article in plain text.",
        ExternalId = "my-title-id",
    }),
    ContentTypePatch.RemoveElement(Reference.ById(Guid.Parse("0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"))),
    ContentTypePatch.MoveElementAfter(
        Reference.ByCodename("my_text_element"),
        Reference.ByExternalId("my-title-id")),
    ContentTypePatch.MoveOptionBefore(
        Reference.ByExternalId("my-multiple-choice-id"),
        Reference.ById(Guid.Parse("d66ffa49-86ff-eeaa-c33b-e5d9eefe8b81")),
        Reference.ById(Guid.Parse("523e6231-8d80-a158-3601-dffde4e64a78")))
])).EnsureSuccess();
