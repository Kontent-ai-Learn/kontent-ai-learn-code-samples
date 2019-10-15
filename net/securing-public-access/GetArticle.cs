// DocSection: securing_public_access_get_article
using Kentico.Kontent.Delivery;

// Initializes a secured content delivery client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UseSecuredProductionApi("<YOUR_API_KEY>")
        .Build())
    .Build();

// Gets a specific content item
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse response = await client.GetItemAsync("on_roasts");

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection