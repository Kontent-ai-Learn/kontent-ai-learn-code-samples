// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
        .UseProductionApi()
        .Build())
    .Build();

// Gets navigation items and their linked items
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var rootResult = await client.GetItem<NavigationItem>("root_navigation_item")
    .Depth(5)
    .ExecuteAsync();

if (!rootResult.IsSuccess)
{
    return;
}

var root = rootResult.Value;

// Gets specific elements of all articles
// With source-generated strongly typed models, GetItems<Article>() adds system.type automatically.
var articleResult = await client.GetItems<Article>()
    .WithElements("title", "url")
    .ExecuteAsync();

if (!articleResult.IsSuccess)
{
    return;
}

var articles = articleResult.Value.Items;