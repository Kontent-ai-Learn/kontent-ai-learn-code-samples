// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Configuration;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(b => b
        .WithEnvironmentId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .Build())
    .Build()
    .Client;

// Gets content items in Spanish without following language fallbacks
var result = await client.GetItems<object>()
    .WithLanguage("es-ES", LanguageFallbackMode.Disabled)
    .ExecuteAsync();

IReadOnlyList<IContentItem<object>> items = result.Value.Items;
