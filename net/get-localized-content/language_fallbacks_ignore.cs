// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets content items in Spanish without following language fallbacks
var result = await client.GetItems()
    .WithLanguage("es-ES", LanguageFallbackMode.Disabled)
    .ExecuteAsync();

if (result.IsSuccess)
{
    var items = result.Value.Items;
}
