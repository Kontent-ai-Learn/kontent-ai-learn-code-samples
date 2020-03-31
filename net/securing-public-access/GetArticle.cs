// DocSection: securing_public_access_get_article
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("<YOUR_PROJECT_ID>")
        .UseProductionApi("<YOUR_API_KEY>")
        .Build())
    .Build();

// Gets a specific content item
// Create strongly typed models according to https://docs.kontent.ai/net-strong-types
DeliveryItemResponse<Article> response = await client.GetItemAsync<Article>("my_article");

Article item = response.Item;
// EndDocSection
