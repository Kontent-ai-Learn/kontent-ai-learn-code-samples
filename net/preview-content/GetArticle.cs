// DocSection: preview_content_get_article
using KenticoCloud.Delivery;

// Initializes a content delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Gets the latest version of a content item
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models
DeliveryItemResponse<object> response = await client.GetItemAsync<object>("on_roasts");

var item = response.Item;
// EndDocSection