// DocSection: delivery_api_get_items_feed
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets feed for specific elements of articles ordered by the "Post date" element
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemsFeed<Article> feed = client.GetItemsFeed<Article>(
    new EqualsFilter("system.type", "article"),
    new ElementsParameter("title", "summary", "post_date"),
    new OrderParameter("elements.post_date", SortOrder.Descending)
    );

while (feed.HasMoreResults)
{
    DeliveryItemsFeedResponse<Article> response = await feed.FetchNextBatchAsync();
    foreach(Article article in response) {
        // Do something with the content item, e.g. update cache
        ProcessContentItem(article);
    }
}
// EndDocSection
