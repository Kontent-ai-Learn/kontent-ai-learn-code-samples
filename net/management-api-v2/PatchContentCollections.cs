// DocSection: cm_api_v2_patch_content_collections
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.ModifyCollectionAsync(new CollectionOperationBaseModel[]
{
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
        CollectionIdentifier = Reference.ByCodename("extra_collection")
    },
    new CollectionReplacePatchModel
    {
        PropertyName = Models.Collections.Patch.PropertyName.Name,
        Value = "A new name",
        Reference = Reference.ByCodename("second_collection")
    }
});
// EndDocSection
