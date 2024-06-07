// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_ENVIRONMENT_ID>")
      .Build();

// Gets 3 content types
IDeliveryTypeListingResponse response = await client.GetTypesAsync(
    new LimitParameter(3)
    );

IList<IContentType> types = response.Types;
