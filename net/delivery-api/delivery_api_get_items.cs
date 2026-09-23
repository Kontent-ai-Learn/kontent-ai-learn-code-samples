// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets 3 articles ordered by the "Post date" element
// Note: When using strongly typed models with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItems<Article>()
var result = await client.GetItems<Article>()
    .OrderBy("elements.post_date", OrderingMode.Descending)
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}