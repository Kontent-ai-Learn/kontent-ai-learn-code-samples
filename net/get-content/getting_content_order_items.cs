// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets the 3 latest articles ordered by their last modified time
// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItems<Article>()
    .OrderBy("system.last_modified", OrderingMode.Descending)
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
