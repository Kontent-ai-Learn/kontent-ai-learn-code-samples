// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets 3 articles ordered by the "Post date" element
// Note: When using source generation with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItems<Article>()
var result = await client.GetItems<Article>()
    .OrderBy("elements.post_date", OrderingMode.Descending)
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}