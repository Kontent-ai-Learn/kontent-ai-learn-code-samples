// DocSection: getting_localized_content_url_slug
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b")
      .Build();

// Gets the 'About us' content item in Spanish based on the item's URL slug value
// Create strongly typed models according to https://docs.kontent.ai/strongly-typed-models
DeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new LanguageParameter("es-ES"),
    new EqualsFilter("system.type", "article"),
    new EqualsFilter("elements.url_pattern", "acerda-de-nosotros")
    );

IReadOnlyList<ContentItem> items = response.Items;
// EndDocSection