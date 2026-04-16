// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a specific taxonomy group
var result = await client.GetTaxonomy("personas").ExecuteAsync();

if (result.IsSuccess)
{
    ITaxonomyGroup taxonomy = result.Value;
}