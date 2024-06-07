// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
// Gets a specific article in Spanish
IDeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("about_us",
    new LanguageParameter("es-ES")
);

Article item = response.Item;
