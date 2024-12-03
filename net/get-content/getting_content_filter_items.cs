// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets all articles
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article")
);

IList<Article> items = response.Items;
