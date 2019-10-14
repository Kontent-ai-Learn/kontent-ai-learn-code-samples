// DocSection: delivery_api_get_types
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets 3 content types
DeliveryTypeListingResponse response = await client.GetTypesAsync(
    new LimitParameter(3)
    );

IReadOnlyList<ContentType> types = response.Types;
// EndDocSection