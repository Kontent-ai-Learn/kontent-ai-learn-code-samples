// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UsePreviewApi("your-preview-api-key")
        .Build())
    .Build();

// Gets the latest version of a content item
// Tip: Generate models via https://github.com/kontent-ai/model-generator-net
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
