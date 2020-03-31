// DocSection: delivery_api_get_types
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets 3 content types
DeliveryTypeListingResponse response = await client.GetTypesAsync(
    new LimitParameter(3)
    );

IReadOnlyList<ContentType> types = response.Types;
// EndDocSection