// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Configuration;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(b => b
        .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
        .Build())
    .Build()
    .Client;

// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
// Filters all articles to find the Spanish variant by its URL slug
var result = await client.GetItems<Article>()
    .WithLanguage("es-ES")
    .Where(f => f
        .System("type").IsEqualTo("article")
        .Element("url_pattern").IsEqualTo("acerda-de-nosotros"))
    .ExecuteAsync();

IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
