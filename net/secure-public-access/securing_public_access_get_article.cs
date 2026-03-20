// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using Microsoft.Extensions.DependencyInjection;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
var services = new ServiceCollection();
services.AddDeliveryClient(options =>
{
    options.EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID";
    options.UseSecureAccess = true;
    options.SecureAccessApiKey = "KONTENT_AI_DELIVERY_API_KEY";
});
using var serviceProvider = services.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<IDeliveryClient>();

// Gets a specific content item
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    var item = result.Value;
}