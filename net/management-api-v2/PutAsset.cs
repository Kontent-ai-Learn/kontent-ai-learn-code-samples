// DocSection: cm_api_v2_put_asset
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = Reference.ByExternalId("which-brewing-fits-you");
// var identifier = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));

// Used when creating a new asset or updating an existing one
var updatedAssetResponse = await client.UpsertAssetAsync(identifier, new AssetUpsertModel
{
    Title = "Coffee Brewing Techniques",
    Descriptions = new List<AssetDescription>
    {
        new AssetDescription
        {
            Description = "Coffee Brewing Techniques",
            Language = Reference.ByCodename("en-US")
        },
        new AssetDescription
        {
            Description = "Técnicas para hacer café",
            Language = Reference.ByCodename("es-ES")
        }
    },
    Elements = ElementBuilder.GetElementsAsDynamic(
        new TaxonomyElement
        {
            Element = Reference.ByCodename("taxonomy-categories"),
            Value = new[]
            {
                Reference.ByCodename("coffee"),
                Reference.ByCodename("brewing"),
            }
        })
});

// Used when creating a new asset or updating an existing one
var createdAssetResponse = await client.UpsertAssetAsync(Reference.ByExternalId("which-brewing-fits-you"), new AssetUpsertModel
{
    // 'fileReference' is only required when creating a new asset
    // To create a file reference, see the "Upload a binary file" endpoint
    FileReference = new FileReference
    {
        Id = "ab7bdf75-781b-4bf9-aed8-501048860402",
        Type = FileReferenceTypeEnum.Internal
    },
    Title = "Coffee Brewing Techniques",
    Descriptions = new AssetDescription[]
    {
        new AssetDescription
        {
            Description = "Coffee Brewing Techniques",
            Language = Reference.ByCodename("en-US")
        },
        new AssetDescription
        {
            Description = "Técnicas para hacer café",
            Language = Reference.ByCodename("es-ES")
        }
    },
    Elements = ElementBuilder.GetElementsAsDynamic(
        new TaxonomyElement
        {
            Element = Reference.ByCodename("taxonomy-categories"),
            Value = new[]
            {
                Reference.ByCodename("coffee"),
                Reference.ByCodename("brewing"),
            }
        })
});
// EndDocSection
