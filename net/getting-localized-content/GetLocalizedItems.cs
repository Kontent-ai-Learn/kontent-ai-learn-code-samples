// DocSection: getting_localized_content_language
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets an article in Spanish
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("on_roasts",
    new LanguageParameter("es-ES")
);

ContentItem item = response.Item;
// EndDocSection