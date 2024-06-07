// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
// Filters all articles to find the Spanish variant by its URL slug
IDeliveryItemListingResponse<Article> response = await client.GetItemsAsync<Article>(
    new LanguageParameter("es-ES"),
    new EqualsFilter("system.type", "article"),
    new EqualsFilter("elements.url_pattern", "acerda-de-nosotros")
    );

IList<Article> items = response.Items;
