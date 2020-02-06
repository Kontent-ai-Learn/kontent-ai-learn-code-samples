// DocSection: delivery_api_get_type
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets a specific content type
DeliveryTypeResponse response = await client.GetTypeAsync("article");
ContentType type = response.Type;
// EndDocSection