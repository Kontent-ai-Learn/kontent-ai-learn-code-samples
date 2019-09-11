// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about .NET SDKs at https://developer.kenticocloud.com/docs/net
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets a specific taxonomy group
DeliveryTaxonomyResponse response = await client.GetTaxonomyAsync("personas");
TaxonomyGroup taxonomy = response.Taxonomy;
// EndDocSection