// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.ItemWithVariant;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

IReadOnlyList<ContentItemWithVariantModel> response = (await client.BulkGetItemsWithVariantsAsync(new ItemWithVariantBulkGetRequestModel
{
    Variants =
    [
        new VariantIdentifierModel
        {
            Item = Reference.ById(Guid.Parse("4b628214-e4fe-4fe0-b1ff-955df33e1515")),
            Language = Reference.ByDefaultId()
        },
        new VariantIdentifierModel
        {
            Item = Reference.ById(Guid.Parse("6a8b4d04-7d3e-4d3c-8b9a-4c7e8f9a1b2c")),
            Language = Reference.ByCodename("en-US")
        }
    ]
})).EnsureSuccess();
