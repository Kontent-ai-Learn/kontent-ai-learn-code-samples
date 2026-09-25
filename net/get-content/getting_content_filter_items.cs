// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets all articles
// Note: When using strongly typed models with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItems<Article>()
var result = await client.GetItems<Article>().ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
