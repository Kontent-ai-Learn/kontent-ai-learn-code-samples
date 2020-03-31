// DocSection: delivery_api_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets specific elements of 3 articles ordered by the "Post date" element
// ProTip: Use https://docs.kontent.ai/net-strong-types
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new ElementsParameter("title", "summary", "post_date"),
    new OrderParameter("elements.post_date", SortOrder.Descending)
    );

IReadOnlyList<Article> items = response.Items;
// EndDocSection