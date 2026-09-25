// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets the model of a specific element within a specific content type
var result = await client.GetContentElement("article", "title").ExecuteAsync();

if (result.IsSuccess)
{
    IContentElement element = result.Value;
    Console.WriteLine($"Name: {element.Name}");
    Console.WriteLine($"Type: {element.Type}");
    Console.WriteLine($"Codename: {element.Codename}");
}