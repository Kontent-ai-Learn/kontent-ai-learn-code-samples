// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Collections;
using Kontent.Ai.Management.Models.Collections.Patch;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.ModifyCollectionsAsync(
[
    new CollectionAddIntoPatchModel
    {
        Value = new CollectionCreateModel
        {
            ExternalId = "another-collection",
            Name = "Another collection",
            Codename = "another_collection_codename"
        },
        After = Reference.ByCodename("second_collection")
    },
    new CollectionMovePatchModel
    {
        Reference = Reference.ByCodename("important_collection"),
        Before = Reference.ByCodename("first_collection")
    },
    new CollectionRemovePatchModel
    {
        Reference = Reference.ByCodename("extra_collection")
    },
    new CollectionReplacePatchModel
    {
        Value = "A new name",
        Reference = Reference.ByCodename("second_collection")
    }
])).EnsureSuccess();
