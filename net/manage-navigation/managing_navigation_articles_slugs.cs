// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets navigation items and their linked items
// Tip: Create strongly typed models according to https://kontent.ai/learn/develop/build-apps/generate-models/net
var rootResult = await client
    .GetItem<NavigationItem>("root_navigation_item")
    .Depth(5)
    .ExecuteAsync();

if (rootResult.IsSuccess)
{
    var root = rootResult.Value.Elements;
}
