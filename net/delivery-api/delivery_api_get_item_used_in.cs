// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Enumerates all parent content items of type "article" for item 'my_article'
await foreach (var usedInItem in client.GetItemUsedIn("my_article")
    .Where(item => item.System("type").IsEqualTo("article"))
    .EnumerateAsync())
{
    // Do something with the parent content item, e.g. update cache
    ProcessUsedInItem(usedInItem);
}