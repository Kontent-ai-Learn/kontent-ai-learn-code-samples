// DocSection: delivery_api_get_element
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the model of specific element within a specific content type
ContentElement element = await client.GetContentElementAsync("coffee", "processing");
// EndDocSection