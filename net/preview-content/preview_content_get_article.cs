// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Configuration;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(b => b
        .WithEnvironmentId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UsePreviewApi("KONTENT_AI_PREVIEW_API_KEY")
        .Build())
    .Build()
    .Client;

// Gets the latest version of a content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

Article item = result.Value.Elements;
