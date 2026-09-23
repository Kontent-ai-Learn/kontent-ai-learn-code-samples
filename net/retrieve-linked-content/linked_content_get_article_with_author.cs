// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a specific article and its linked items
// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
var result = await client.GetItem<SimpleArticle>("the_origin_of_coffee")
    .Depth(1)
    .ExecuteAsync();

if (result.IsSuccess)
{
    SimpleArticle item = result.Value.Elements;
}
