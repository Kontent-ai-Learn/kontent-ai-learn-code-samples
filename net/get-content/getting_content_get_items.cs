// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets all content items
// Note: Without type parameter, GetItems() returns either runtime typed items or falls back to DynamicElements
// see https://github.com/kontent-ai/delivery-sdk-net#dynamic-content-access for details
var result = await client.GetItems().ExecuteAsync();

if (result.IsSuccess)
{
    var items = result.Value.Items;
}
