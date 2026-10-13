// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets content items in Spanish without following language fallbacks
var result = await client.GetItems()
    .WithLanguage("es-ES", LanguageFallbackMode.Disabled)
    .ExecuteAsync();

if (result.IsSuccess)
{
    var items = result.Value.Items;
}
