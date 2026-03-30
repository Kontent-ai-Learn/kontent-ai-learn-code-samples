// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets all articles
// Note: When using strongly typed models with [ContentTypeCodename("article")],
// the system.type filter is added automatically for GetItems<Article>()
var result = await client.GetItems<Article>().ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
