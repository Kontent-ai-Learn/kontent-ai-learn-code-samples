// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_ENVIRONMENT_ID>")
      .Build();

// Gets 3 taxonomy groups
IDeliveryTaxonomyListingResponse response = await client.GetTaxonomiesAsync(
    new LimitParameter(3)
    );

IList<ITaxonomyGroup> taxonomies = response.Taxonomies;
// EndDocSection