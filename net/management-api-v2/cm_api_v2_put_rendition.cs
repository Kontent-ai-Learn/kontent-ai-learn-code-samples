// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.AssetRenditions;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = AssetRenditionIdentifier.ByIds(Guid.Parse("fcbb12e6-66a3-4672-85d9-d502d16b8d9c"), Guid.Parse("ce559491-0fc1-494b-96f3-244bc095de57"));
// var identifier = new AssetRenditionIdentifier(Reference.ByExternalId("which-brewing-fits-you"), Reference.ByExternalId("hero-image-rendition"));

var response = (await client.UpdateAssetRenditionAsync(identifier, new AssetRenditionUpdateModel()
{
    Transformation = new RectangleResizeTransformation
    {
        CustomWidth = 120,
        CustomHeight = 240,
        X = 300,
        Y = 200,
        Width = 360,
        Height = 720,
    }
})).EnsureSuccess();
