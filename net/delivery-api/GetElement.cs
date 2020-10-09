// DocSection: delivery_api_get_element
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets the model of specific element within a specific content type
DeliveryElementResponse response = await client.GetContentElementAsync("article", "title");
IContentElement element = response.Element;
// EndDocSection