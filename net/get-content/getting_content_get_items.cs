// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets all content items
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
IDeliveryItemListingResponse<object> response = await client.GetItemsAsync<object>();

IList<object> items = response.Items;
