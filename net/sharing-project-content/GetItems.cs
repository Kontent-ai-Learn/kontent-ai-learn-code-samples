// DocSection: sharing_project_content_get_items
using Kentico.Kontent.Delivery;

// Initializes the first content delivery client
protected static IDeliveryClient client1 = DeliveryClientBuilder
    .WithOptions(builder => builder
            .WithProjectId("368d5707-fb05-0146-fc0a-f85c5d1a264e")
            .UseProductionApi
            .Build())
    .Build();

// Initializes the second content delivery client
protected static IDeliveryClient client2 = DeliveryClientBuilder
    .WithOptions(builder => builder
            .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
            .UseProductionApi
            .Build())
    .Build();

// Gets content items from both projects
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
DeliveryItemListingResponse<object> client1Response = await client1.GetItemsAsync<object>();
DeliveryItemListingResponse<object> client2Response = await client2.GetItemsAsync<object>();

// Concatenate the results
IReadOnlyList<ContentItem> items = client1Response.Items.Concat(client2Response.Items).ToArray();
// EndDocSection