// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets a specific taxonomy group
var result = await client.GetTaxonomy("personas").ExecuteAsync();

if (result.IsSuccess)
{
    ITaxonomyGroup taxonomy = result.Value;
}