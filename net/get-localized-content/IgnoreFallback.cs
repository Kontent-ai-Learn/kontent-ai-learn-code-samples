// DocSection: language_fallbacks_ignore
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the Spanish variant of all content items and ignores language fallbacks
IDeliveryItemListingResponse<object> response = await 
client.GetItemsAsync<object>(
    new LanguageParameter("es-ES"),
    new EqualsFilter("system.language", "es-ES")
    );

IList<object> items = response.Items;
// EndDocSection
