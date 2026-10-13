// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
// Gets a specific article in Spanish (with language fallbacks enabled by default)
var result = await client.GetItem<Article>("about_us")
    .WithLanguage("es-ES")
    .ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
