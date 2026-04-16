// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Enumerates all parent content items of type "article" for asset 'my_asset'
await foreach (var usedInItem in client.GetAssetUsedIn("my_asset")
    .Where(item => item.System("type").IsEqualTo("article"))
    .EnumerateAsync())
{
    // Do something with the parent content item, e.g. update cache
    ProcessUsedInItem(usedInItem);
}
