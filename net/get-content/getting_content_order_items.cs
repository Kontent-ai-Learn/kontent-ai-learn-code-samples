// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets the 3 latest articles ordered by their last modified time
// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
var result = await client.GetItems<Article>()
    .OrderBy("system.last_modified", OrderingMode.Descending)
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
