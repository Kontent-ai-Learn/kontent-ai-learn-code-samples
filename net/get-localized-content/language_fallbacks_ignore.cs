// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
      .Build();

// Gets content items in Spanish without following language fallbacks
IDeliveryItemListingResponse<object> response = await 
client.GetItemsAsync<object>(
    new LanguageParameter("es-ES"),
    new EqualsFilter("system.language", "es-ES")
    );

IList<object> items = response.Items;
