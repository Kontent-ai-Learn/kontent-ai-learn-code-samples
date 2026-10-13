// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Enumerates all articles in the project
// Note: When using strongly typed models with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItemsFeed<Article>()
await foreach (var article in client.GetItemsFeed<Article>().EnumerateAsync())
{
    // Do something with the content item, e.g. update cache
    ProcessContentItem(article.Elements);
}