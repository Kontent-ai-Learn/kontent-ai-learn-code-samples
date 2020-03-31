// DocSection: getting_articles_with_taxonomy_term
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets articles tagged with the barista persona
// Create strongly typed models according to https://docs.kontent.ai/net-strong-types
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new EqualsFilter("system.type", "article"),
    new ContainsFilter("elements.personas", "barista")
);

IReadOnlyList<Article> items = response.Items;
// EndDocSection