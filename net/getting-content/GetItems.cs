// DocSection: getting_content_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b")
      .Build();

// Gets all content items
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
DeliveryItemListingResponse<object> response = await client.GetItemsAsync<object>();

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection