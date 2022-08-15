// DocSection: getting_localized_content_language
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets an article in Spanish
// Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("about_us",
    new LanguageParameter("es-ES")
);

Article item = response.Item;
// EndDocSection