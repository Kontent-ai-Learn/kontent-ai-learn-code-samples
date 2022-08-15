// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
    .Build();

// Gets a specific page, its subpages, and linked items
// Create strongly typed models according to https://kontent.ai/learn/net-strong-types
IDeliveryItemResponse<Page> response = await client.GetItemAsync<Page>("insurance_listing",
    new DepthParameter(1)
    );

Page item = response.Item;
// EndDocSection