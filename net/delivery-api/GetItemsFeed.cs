// DocSection: delivery_api_get_items_feed
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client; see https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets feed of all articles in the project 
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemsFeed<Article> feed = client.GetItemsFeed<Article>(
    new EqualsFilter("system.type", "article")
    );

while (feed.HasMoreResults)
{
    IDeliveryItemsFeedResponse<Article> response = await feed.FetchNextBatchAsync();
    foreach(Article article in response) {
        // Do something with the content item, e.g. update cache
        ProcessContentItem(article);
    }
}
// EndDocSection
