// DocSection: delivery_api_get_types
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets 3 content types
DeliveryTypeListingResponse response = await client.GetTypesAsync(
    new LimitParameter(3)
    );

IReadOnlyList<ContentType> types = response.Types;
// EndDocSection