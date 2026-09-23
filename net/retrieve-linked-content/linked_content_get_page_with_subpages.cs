// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a specific page, its subpages, and linked items
// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
var result = await client.GetItem<Page>("insurance_listing")
    .Depth(1)
    .ExecuteAsync();

if (result.IsSuccess)
{
    Page item = result.Value.Elements;
}
