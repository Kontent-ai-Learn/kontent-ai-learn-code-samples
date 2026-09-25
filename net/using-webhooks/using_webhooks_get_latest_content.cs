// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a content item; asks the API to return the latest content if it changed since the last request
// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
var result = await client.GetItem<Article>("my_article")
    .WaitForLoadingNewContent(true)
    .ExecuteAsync();

if (result.IsSuccess)
{
    Article item = result.Value.Elements;
}
