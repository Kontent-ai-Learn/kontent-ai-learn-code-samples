// DocSection: using_webhooks_get_latest_content
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a client that retrieves the latest version of published content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UseProductionApi
        .WaitForLoadingNewContent
        .Build())
    .Build();

// Gets a content item
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemResponse response = await client.GetItemAsync("on_roasts");

ContentItem item = response.Item;
// EndDocSection