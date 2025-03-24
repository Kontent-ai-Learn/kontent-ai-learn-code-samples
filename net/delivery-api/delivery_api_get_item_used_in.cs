// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client; see https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
      .Build();

// Gets feed of all strongly typed parent content items of type article for item 'my_article'
IDeliveryItemsFeed<IUsedInItem> feed = client.GetItemUsedIn("my_article",
    new EqualsFilter("system.type", "article")
    );

while (feed.HasMoreResults)
{
    IDeliveryItemsFeedResponse<IUsedInItem> response = await feed.FetchNextBatchAsync();
    foreach(IUsedInItem usedInItem in response) {
        // Do something with the parent content item, e.g. update cache
        ProcessUsedInItem(usedInItem);
    }
}
