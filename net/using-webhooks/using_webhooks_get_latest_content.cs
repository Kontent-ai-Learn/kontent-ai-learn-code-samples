// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Initializes a client that retrieves the latest version of published content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
        .UseProductionApi
        .WaitForLoadingNewContent
        .Build())
    .Build();

// Gets a content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("my_article");

Article item = response.Item;
