// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

var client = clientContainer.Client;

// Gets navigation items and their linked items
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
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
