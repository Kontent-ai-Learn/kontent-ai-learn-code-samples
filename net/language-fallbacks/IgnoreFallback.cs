// DocSection: language_fallbacks_ignore
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://docs.kontent.ai/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the Spanish variant of all content items and ignores language fallbacks
DeliveryItemListingResponse<object> response = await 
client.GetItemsAsync<object>(
    new LanguageParameter("es-ES"),
    new EqualsParameter("system.language", "es-ES")
    );

IReadOnlyList<object> items = response.Items;
// EndDocSection
