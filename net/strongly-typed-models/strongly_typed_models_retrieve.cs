// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;
using KontentAiModels;

// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a content item by codename and maps it to the strongly typed model
var result = await client.GetItem<Homepage>("hello_caas_world").ExecuteAsync();

if (result.IsSuccess)
{
    var homepage = result.Value.Elements;
    // Use homepage
    // Console.WriteLine(homepage.Headline);
}