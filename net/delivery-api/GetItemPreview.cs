// DocSection: delivery_api_get_item_preview
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Generate strongly typed models via https://github.com/Kentico/kontent-generators-net
DeliveryItemResponse response = await client.GetItemAsync("on_roasts");
ContentItem item = response.Item;
// EndDocSection
