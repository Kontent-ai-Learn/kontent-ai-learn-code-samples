// DocSection: delivery_api_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets specific elements of 3 articles ordered by the "Post date" element
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new ElementsParameter("title", "summary", "post_date"),
    new OrderParameter("elements.post_date", SortOrder.Descending)
    );

var items = response.Items;
// EndDocSection