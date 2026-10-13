// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.Spaces.Patch;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("6291c693-f6e4-4a6b-ac67-5c31c32f9388"));
// var identifier = Reference.ByCodename("space_1");

var response = (await client.ModifySpaceAsync(identifier,
[
    SpacePatch.Name("New space name"),
    SpacePatch.Codename("new_space_codename"),
    SpacePatch.RootItem(Reference.ById(Guid.Parse("1024356f-858f-421a-b804-07c6bfe10ce5"))),
    SpacePatch.Collections(Reference.ByCodename("first_collection"), Reference.ByCodename("extra_collection")),
])).EnsureSuccess();
