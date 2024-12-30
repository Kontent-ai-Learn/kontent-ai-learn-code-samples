// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
        .UseProductionApi("KONTENT_AI_DELIVERY_API_KEY")
        .Build())
    .Build();

// Gets a specific content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("my_article");

Article item = response.Item;
