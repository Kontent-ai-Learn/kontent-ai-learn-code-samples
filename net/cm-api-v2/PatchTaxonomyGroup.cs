// DocSection: cm_api_v2_patch_taxonomy_group
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("personas");
// var identifier = Reference.ByExternalId("Tax-Group-123");

var response = await client.ModifyTaxonomyGroupAsync(identifier, new TaxonomyGroupOperationBaseModel[]
{
    new TaxonomyGroupReplacePatchModel
    {
        PropertyName = PropertyName.Name,
        Value = "Categories"
    },
    new TaxonomyGroupReplacePatchModel
    {
        PropertyName = PropertyName.Codename,
        Value = "category"
    },
    new TaxonomyGroupReplacePatchModel
    {
        Reference = Reference.ByCodename("first_term"),
        PropertyName = PropertyName.Terms,
        Value = new TaxonomyGroupCreateModel[]
        {
            new TaxonomyGroupCreateModel
            {
                Name = "Second-level taxonomy term",
                Codename = "second_term",
                Terms = new TaxonomyGroupCreateModel[]
                {
                    new TaxonomyGroupCreateModel
                    {
                        Name = "Third-level taxonomy term",
                    }
                }
            }
        }
    },
    new TaxonomyGroupRemovePatchModel
    {
        Reference = Reference.ByExternalId("unused-taxonomy-term")
    },
    new TaxonomyGroupAddIntoPatchModel
    {
        Reference = Reference.ByCodename("second_term"),
        Value = new TaxonomyGroupCreateModel
        {
            Name = "New taxonomy term",
            ExternalId = "my-new-term",
            Terms = Array.Empty<TaxonomyGroupCreateModel>()
        }
    }
});
// EndDocSection
