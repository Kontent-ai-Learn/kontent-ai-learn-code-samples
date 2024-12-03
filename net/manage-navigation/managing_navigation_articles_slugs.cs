// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets navigation items and their linked items
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<NavigationItem> rootResponse = await client.GetItemAsync<NavigationItem>("root_navigation_item",
    new DepthParameter(5)
    );

NavigationItem root = rootResponse.Item;

// Gets specific elements of all articles
IDeliveryItemListingResponse<Article> articleResponse = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new ElementsParameter("title", "url")
    );

var articles = articleResponse.Items;
