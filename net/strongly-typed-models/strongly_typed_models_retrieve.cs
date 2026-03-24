// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Configuration;
using KontentAiModels;

// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

var client = clientContainer.Client;

// Gets a content item by codename and maps it to the strongly typed model
var result = await client.GetItem<Homepage>("hello_caas_world").ExecuteAsync();

if (result.IsSuccess)
{
    var homepage = result.Value.Elements;
    // Use homepage
    // Console.WriteLine(homepage.Headline);
}