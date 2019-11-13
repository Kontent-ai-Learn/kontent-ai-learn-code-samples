// DocSection: building_first_net_app_model_mapping
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Retrieves 3 articles ordered by their post date
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new LimitParameter(3),
    new OrderParameter("elements.post_date", SortOrder.Descending)
);

// Sends the strongly-typed content items to a View
return View(response.Items)
// EndDocSection