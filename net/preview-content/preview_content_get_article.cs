// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }
    .UsePreviewApi("your-preview-api-key"));

// Gets the latest version of a content item
// Tip: Generate models via https://github.com/kontent-ai/dotnet/tree/main/src/model-generator
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
