// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets all content items
// Note: Without type parameter, GetItems() returns either runtime typed items or falls back to DynamicElements
// see https://github.com/kontent-ai/dotnet/blob/main/src/delivery/docs/models.md#dynamic-content-access for details
var result = await client.GetItems().ExecuteAsync();

if (result.IsSuccess)
{
    var items = result.Value.Items;
}
