// DocSection: getting_content_order_items
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the 3 latest articles ordered by their last modified time
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new LimitParameter(3),
    new OrderParameter("system.last_modified", SortOrder.Descending)
);

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection