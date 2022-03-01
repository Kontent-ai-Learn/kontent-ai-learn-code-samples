// DocSection: cm_api_v2_get_rendition
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var assetReference = Reference.ById(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"));
// var assetReference = Reference.ByExternalId("which-brewing-fits-you");
var renditionReference = Reference.ById(Guid.Parse("ce559491-0fc1-494b-96f3-244bc095de57"));
// var renditionReference = Reference.ByExternalId("hero-image-rendition");

var identifier = new AssetRenditionIdentifier(assetReference, renditionReference);

var response = await client.GetAssetRenditionAsync(identifier);
// EndDocSection