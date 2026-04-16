// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Gets 3 languages
var result = await client.GetLanguages()
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<ILanguage> languages = result.Value.Languages;
}