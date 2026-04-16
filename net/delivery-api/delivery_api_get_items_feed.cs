// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Enumerates all articles in the project
// Note: When using strongly typed models with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItemsFeed<Article>()
await foreach (var article in client.GetItemsFeed<Article>().EnumerateAsync())
{
    // Do something with the content item, e.g. update cache
    ProcessContentItem(article.Elements);
}