// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets a specific taxonomy group
DeliveryTaxonomyResponse response = await client.GetTaxonomyAsync("personas");
TaxonomyGroup taxonomy = response.Taxonomy;
// EndDocSection