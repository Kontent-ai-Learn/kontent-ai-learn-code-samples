// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
// Gets a specific article in Spanish (with language fallbacks enabled by default)
var result = await client.GetItem<Article>("about_us")
    .WithLanguage("es-ES")
    .ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
