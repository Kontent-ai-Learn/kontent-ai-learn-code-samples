// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Initializes a client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a content item and bypasses SDK local cache for this request path
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article")
    .WaitForLoadingNewContent(true)
    .ExecuteAsync();

if (result.IsSuccess)
{
    var item = result.Value;
}