// DocSection: cm_api_v2_delete_taxonomy_group
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});


var identifier = Reference.ById(Guid.Parse("0be13600-e57c-577d-8108-c8d860330985"));
// var identifier = Reference.ByCodename("personas");
// var identifier = Reference.ByExternalId("Tax-Group-123");

await client.DeleteTaxonomyGroupAsync(identifier);
// EndDocSection