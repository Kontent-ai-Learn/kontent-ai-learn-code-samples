// DocSection: linked_content_get_article_with_author
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets a specific article and its linked items
// Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<SimpleArticle> response = await client.GetItemAsync<SimpleArticle>("the_origin_of_coffee",
    new DepthParameter(1)
    );

SimpleArticle item = response.Item;
// EndDocSection