// Or register it through DI with services.AddDeliveryClient()
using var client = DeliveryClient.Create(new DeliveryOptions { EnvironmentId = "your-environment-id" }.UseProductionApi());

// Gets 3 taxonomy groups
var result = await client.GetTaxonomies()
    .Limit(3)
    .ExecuteAsync();

if (result.IsSuccess)
{
    IReadOnlyList<ITaxonomyGroup> taxonomies = result.Value.Taxonomies;
}