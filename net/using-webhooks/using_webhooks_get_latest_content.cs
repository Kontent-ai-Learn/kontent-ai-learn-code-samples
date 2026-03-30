// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a content item; asks the API to return the latest content if it changed since the last request
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article")
    .WaitForLoadingNewContent(true)
    .ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
