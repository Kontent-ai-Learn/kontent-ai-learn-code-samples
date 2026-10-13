// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;

// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }
    .UseProductionApi("your-delivery-api-key"));

// Gets a specific content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
