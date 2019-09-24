// DocSection: using_webhooks_get_latest_content
using KenticoCloud.Delivery;

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
DeliveryItemResponse<object> response = await client.GetItemAsync<object>("on_roasts");
// EndDocSection