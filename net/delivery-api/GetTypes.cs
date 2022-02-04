// DocSection: delivery_api_get_types
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets 3 content types
IDeliveryTypeListingResponse response = await client.GetTypesAsync(
    new LimitParameter(3)
    );

IList<IContentType> types = response.Types;
// EndDocSection