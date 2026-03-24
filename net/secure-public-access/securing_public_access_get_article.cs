// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Create a delivery client with secure access
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi("your-delivery-api-key")
        .Build())
    .Build();

var client = clientContainer.Client;

// Gets a specific content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
