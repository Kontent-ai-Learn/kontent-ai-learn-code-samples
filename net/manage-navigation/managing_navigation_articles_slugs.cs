// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets navigation items and their linked items
// Tip: Create strongly typed models according to https://kontent.ai/learn/develop/build-apps/generate-models/net
var rootResult = await client.GetItem<NavigationItem>("root_navigation_item")
    .Depth(5)
    .ExecuteAsync();

if (rootResult.IsSuccess)
{
    var root = rootResult.Value.Elements;
}

// Gets specific elements of all articles
// With source-generated strongly typed models, GetItems<Article>() adds system.type automatically.
var articleResult = await client.GetItems<Article>()
    .WithElements("title", "url")
    .ExecuteAsync();

if (articleResult.IsSuccess)
{
    var articles = articleResult.Value.Items;
}
