// DocSection: getting_localized_content_url_slug
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the Home content item in Spanish based on the item's URL slug value
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Home> response = await client.GetItemsAsync<Home>(
    new LanguageParameter("es-ES"),
    new EqualsFilter("system.type", "home"),
    new EqualsFilter("elements.url_pattern", "inicio")
    );

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection