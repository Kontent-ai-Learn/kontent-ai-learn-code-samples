// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets 3 taxonomy groups
DeliveryTaxonomyListingResponse response = await client.GetTaxonomiesAsync(
    new LimitParameter(3)
    );

IReadOnlyList<TaxonomyGroup> taxonomies = response.Taxonomies;
// EndDocSection