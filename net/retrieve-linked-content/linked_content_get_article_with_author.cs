// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a specific article and its linked items
// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItem<SimpleArticle>("the_origin_of_coffee")
    .Depth(1)
    .ExecuteAsync();

if (result.IsSuccess)
{
    SimpleArticle item = result.Value.Elements;
}
