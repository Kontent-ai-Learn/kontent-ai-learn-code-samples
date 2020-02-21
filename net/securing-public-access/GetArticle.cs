// DocSection: securing_public_access_get_article
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a secured content delivery client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("<YOUR_PROJECT_ID>")
        .UseProductionApi("<YOUR_API_KEY>")
        .Build())
    .Build();

// Gets a specific content item
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse response = await client.GetItemAsync("my_article");

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection
