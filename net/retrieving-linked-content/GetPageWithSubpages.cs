// DocSection: linked_content_get_page_with_subpages
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets a specific page, its subpages, and linked items
// Create strongly typed models according to https://docs.kontent.ai/net-strong-types
DeliveryItemResponse<Page> response = await client.GetItemAsync<Page>("insurance_listing",
    new DepthParameter(1)
    );

Page item = response.Item;
// EndDocSection