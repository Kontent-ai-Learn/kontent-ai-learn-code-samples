// DocSection: latest_articles_get_5articles_orderfilt
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets specific elements of 5 articles sorted by post date
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new OrderParameter("elements.post_date", SortOrder.Descending),
    new LimitParameter(5),
    new ElementsParameter("title", "teaser_image")
);

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection