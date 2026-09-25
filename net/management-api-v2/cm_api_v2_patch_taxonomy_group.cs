// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.TaxonomyGroups;
using Kontent.Ai.Management.Models.TaxonomyGroups.Patch;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("personas");
// var identifier = Reference.ByExternalId("Tax-Group-123");

var response = (await client.ModifyTaxonomyGroupAsync(identifier,
[
    TaxonomyGroupPatch.ReplaceName(identifier, "Categories"),
    TaxonomyGroupPatch.ReplaceCodename(identifier, "category"),
    TaxonomyGroupPatch.ReplaceTerms(Reference.ByCodename("first_term"),
        new TaxonomyTermCreateModel
        {
            Name = "Second-level taxonomy term",
            Codename = "second_term",
            Terms =
            [
                new TaxonomyTermCreateModel
                {
                    Name = "Third-level taxonomy term",
                }
            ]
        }),
    new TaxonomyGroupRemovePatchModel
    {
        Reference = Reference.ByExternalId("unused-taxonomy-term")
    },
    new TaxonomyGroupAddIntoPatchModel
    {
        Reference = Reference.ByCodename("second_term"),
        Value = new TaxonomyTermCreateModel
        {
            Name = "New taxonomy term",
            ExternalId = "my-new-term",
        }
    },
    new TaxonomyGroupMovePatchModel
    {
        Reference = Reference.ByExternalId("my-new-term"),
        Before = Reference.ByCodename("first_term")
    }
])).EnsureSuccess();
