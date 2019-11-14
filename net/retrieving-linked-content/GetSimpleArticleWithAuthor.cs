// DocSection: linked_content_get_article_with_author
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("e6d2946e-0e24-003f-a397-9d2d458c6d6e")
      .Build();

// Gets a specific article and its linked items
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse<SimpleArticle> response = await client.GetItemAsync<SimpleArticle>("the_origin_of_coffee",
    new DepthParameter(1)
    );

ContentItem item = response.Item;
// EndDocSection