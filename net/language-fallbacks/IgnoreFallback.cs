// DocSection: language_fallbacks_ignore
using KenticoCloud.Delivery;

// Initializes a content delivery client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets the Spanish variant of all articles and ignores language fallbacks
DeliveryItemListingResponse<object> response = await 
client.GetItemsAsync<object>(
    new LanguageParameter("es-ES"),
    new EqualsParameter("system.language", "es-ES")
    );

var items = response.Items;
// EndDocSection
