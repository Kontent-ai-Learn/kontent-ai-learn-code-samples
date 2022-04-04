// DocSection: cm_api_v2_post_asset
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateAssetAsync(new AssetCreateModel
{
    FileReference = new FileReference
    {
        Id = "fcbb12e6-66a3-4672-85d9-d502d16b8d9c",
        Type = FileReferenceTypeEnum.Internal
    },
    Folder = Reference.ByExternalId("another-folder"),
    Title = "Coffee Brewing Techniques",
    ExternalId = "which-brewing-fits-you",
    Descriptions = new[]
    {
        new AssetDescription
        {
            Language = Reference.ByCodename("en-US"),
            Description = "Coffee Brewing Techniques"
        },
            new AssetDescription
        {
            Language = Reference.ByCodename("es-ES"),
            Description = "Técnicas para hacer café"
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
