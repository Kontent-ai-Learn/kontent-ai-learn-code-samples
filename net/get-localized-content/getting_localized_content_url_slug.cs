// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
// Filters all articles to find the Spanish variant by its URL slug
var result = await client.GetItems<Article>()
    .WithLanguage("es-ES")
    .Where(item => item.Element("url_pattern").IsEqualTo("acerda-de-nosotros"))
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
