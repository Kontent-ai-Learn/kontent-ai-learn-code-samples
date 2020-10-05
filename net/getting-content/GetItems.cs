// DocSection: getting_content_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets all content items
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
IDeliveryItemListingResponse<object> response = await client.GetItemsAsync<object>();

IList<object> items = response.Items;
// EndDocSection