// DocSection: sharing_project_content_get_items
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes the first content delivery client
IDeliveryClient client1 = DeliveryClientBuilder
        .WithProjectId("368d5707-fb05-0146-fc0a-f85c5d1a264e")
        .Build();

// Initializes the second content delivery client
IDeliveryClient client2 = DeliveryClientBuilder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .Build();

// Gets content items from both projects
// Note: Using the <object> generic parameter produces strongly typed objects, based on "system.type"
DeliveryItemListingResponse<object> client1Response = await client1.GetItemsAsync<object>();
DeliveryItemListingResponse<object> client2Response = await client2.GetItemsAsync<object>();

// Concatenate the results
IReadOnlyList<ContentItem> items = client1Response.Items.Concat(client2Response.Items).ToArray();
// EndDocSection