// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

var client = clientContainer.Client;

// Gets a content item; asks the API to return the latest content if it changed since the last request
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article")
    .WaitForLoadingNewContent(true)
    .ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
