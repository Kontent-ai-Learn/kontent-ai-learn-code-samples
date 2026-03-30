// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
      .WithOptions(builder => builder
            .WithEnvironmentId("your-environment-id")
            .UseProductionApi()
            .Build())
      .Build();

// Gets the model of a specific element within a specific content type
var result = await client.GetContentElement("article", "title").ExecuteAsync();

if (result.IsSuccess)
{
      IContentElement element = result.Value;
      Console.WriteLine($"Name: {element.Name}");
      Console.WriteLine($"Type: {element.Type}");
      Console.WriteLine($"Codename: {element.Codename}");
}