// DocSection: delivery_api_get_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets specific elements of an article
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("my_article",
    new ElementsParameter("title", "summary", "post_date", "teaser_image", "related_articles")
    );

Article item = response.Item;
// EndDocSection