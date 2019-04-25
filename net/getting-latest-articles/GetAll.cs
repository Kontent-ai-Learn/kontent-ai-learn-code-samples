// DocSection: getting_latest_articles_get_all
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets all content items
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
DeliveryItemListingResponse<object> response = await client.GetItemsAsync<object>();

var items = response.Items;
// EndDocSection