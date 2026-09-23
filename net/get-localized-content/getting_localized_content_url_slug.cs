// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
// Filters all articles to find the Spanish variant by its URL slug
var result = await client.GetItems<Article>()
    .WithLanguage("es-ES")
    .Where(item => item.Element("url_pattern").IsEqualTo("acerda-de-nosotros"))
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
}
