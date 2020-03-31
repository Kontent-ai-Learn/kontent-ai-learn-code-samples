// DocSection: getting_localized_content_language
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets an article in Spanish
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("about_us",
    new LanguageParameter("es-ES")
);

ContentItem item = response.Item;
// EndDocSection