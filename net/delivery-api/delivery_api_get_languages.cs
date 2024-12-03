// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
      .Build();

// Gets 3 languages
IDeliveryLanguageListingResponse response = await deliveryClient.GetLanguagesAsync(
    new List<IQueryParameter>() {
        new LimitParameter(3)
    });

IList<ILanguage> languages = response.Languages;
