// DocSection: latest_articles_get_all
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets all content items
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
DeliveryItemListingResponse<object> response = await client.GetItemsAsync<object>();

IReadOnlyList<object> items = response.Items;
// EndDocSection