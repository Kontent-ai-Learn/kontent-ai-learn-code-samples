// DocSection: delivery_api_get_item
// Tip: Find more about .NET SDKs at https://developer.kenticocloud.com/docs/net
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets specific elements of an article
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("on_roasts",
    new ElementsParameter("title", "summary", "post_date", "teaser_image", "related_articles")
    );

Article item = response.Item;
// EndDocSection