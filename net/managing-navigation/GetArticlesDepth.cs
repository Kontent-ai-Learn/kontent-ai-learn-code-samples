// DocSection: managing_navigation_articles_depth
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets navigation items and their linked items
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse<NavigationItem> response =  await client.GetItemAsync<NavigationItem>("root_navigation_item",
    new DepthParameter(5)
    );

ContentItem item = response.Item;
// EndDocSection