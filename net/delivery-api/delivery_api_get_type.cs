// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a specific content type
var result = await client.GetType("article").ExecuteAsync();

if (result.IsSuccess)
{
    IContentType type = result.Value;
}