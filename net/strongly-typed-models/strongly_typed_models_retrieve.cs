// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Configuration;
using KontentAiModels;

// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets a content item by codename and maps it to the strongly typed model
var result = await client.GetItem<Homepage>("hello_caas_world").ExecuteAsync();

if (result.IsSuccess)
{
    var homepage = result.Value.Elements;
    // Use homepage
    // Console.WriteLine(homepage.Headline);
}