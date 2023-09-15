// DocSection: delivery_api_get_languages
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Creates an instance of the delivery client
// ProTip: Use DI for this in your apps https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithProjectId("<YOUR_ENVIRONMENT_ID>")
      .Build();

// Gets 3 languages
IDeliveryLanguageListingResponse response = await deliveryClient.GetLanguagesAsync(
    new List<IQueryParameter>() {
        new LimitParameter(3)
    });

IList<ILanguage> languages = response.Languages;
// EndDocSection