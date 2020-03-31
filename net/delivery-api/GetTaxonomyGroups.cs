// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-delivery-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets 3 taxonomy groups
DeliveryTaxonomyListingResponse response = await client.GetTaxonomiesAsync(
    new LimitParameter(3)
    );

IReadOnlyList<TaxonomyGroup> taxonomies = response.Taxonomies;
// EndDocSection