// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Configuration;
using KontentAiModels;

// Tip: Without DI, build the client via DeliveryClientBuilder.WithOptions(...)
using var container = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
        .UseProductionApi()
        .Build())
    .Build();

IDeliveryClient client = container.Client;

// Gets a content item by codename and maps it to the strongly typed model
var result = await client.GetItem<Homepage>("hello_caas_world").ExecuteAsync();

if (result.IsSuccess)
{
    var homepage = result.Value.Elements;
    // Use homepage
    // Console.WriteLine(homepage.Headline);
}