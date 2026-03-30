// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a specific content type
var result = await client.GetType("article").ExecuteAsync();

if (result.IsSuccess)
{
    IContentType type = result.Value;
}