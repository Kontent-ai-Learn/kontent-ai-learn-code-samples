// DocSection: preview_content_get_article
using Kentico.Kontent.Delivery;

// Initializes a content delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Gets the latest version of a content item
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse response = await client.GetItemAsync("on_roasts");

ContentItem item = response.Item;
// EndDocSection