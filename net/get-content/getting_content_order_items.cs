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

// Gets the 3 latest articles ordered by their last modified time
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItems<Article>()
    .Where(f => f.System("type").IsEqualTo("article"))
    .Limit(3)
    .OrderBy("system.last_modified", OrderingMode.Descending)
    .ExecuteAsync();

IReadOnlyList<IContentItem<Article>> items = result.Value.Items;
