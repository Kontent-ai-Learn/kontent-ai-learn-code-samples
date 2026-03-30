// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a specific page, its subpages, and linked items
// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItem<Page>("insurance_listing")
    .Depth(1)
    .ExecuteAsync();

if (result.IsSuccess)
{
    Page item = result.Value.Elements;
}
