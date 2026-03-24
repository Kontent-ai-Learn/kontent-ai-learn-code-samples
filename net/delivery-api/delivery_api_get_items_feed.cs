// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

// Enumerates all articles in the project
// Note: When using source generation with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItemsFeed<Article>()
await foreach (var article in client.GetItemsFeed<Article>().EnumerateAsync())
{
    // Do something with the content item, e.g. update cache
    ProcessContentItem(article.Elements);
}