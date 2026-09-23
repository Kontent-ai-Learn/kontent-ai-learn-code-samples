// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Enumerates all parent content items of type "article" for asset 'my_asset'
await foreach (var usedInItem in client.GetAssetUsedIn("my_asset")
    .Where(item => item.System("type").IsEqualTo("article"))
    .EnumerateAsync())
{
    // Do something with the parent content item, e.g. update cache
    ProcessUsedInItem(usedInItem);
}
