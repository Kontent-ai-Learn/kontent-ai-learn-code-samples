// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Enumerates all parent content items of type "article" for item 'my_article'
await foreach (var usedInItem in client.GetItemUsedIn("my_article")
    .Where(item => item.System("type").IsEqualTo("article"))
    .EnumerateAsync())
{
    // Do something with the parent content item, e.g. update cache
    ProcessUsedInItem(usedInItem);
}