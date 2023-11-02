// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_ENVIRONMENT_ID>")
      .Build();

// Gets a specific taxonomy group
IDeliveryTaxonomyResponse response = await client.GetTaxonomyAsync("personas");
ITaxonomyGroup taxonomy = response.Taxonomy;
