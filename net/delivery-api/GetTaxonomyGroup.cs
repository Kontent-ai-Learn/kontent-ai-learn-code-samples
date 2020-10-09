// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_PROJECT_ID>")
      .Build();

// Gets a specific taxonomy group
IDeliveryTaxonomyResponse response = await client.GetTaxonomyAsync("personas");
ITaxonomyGroup taxonomy = response.Taxonomy;
// EndDocSection