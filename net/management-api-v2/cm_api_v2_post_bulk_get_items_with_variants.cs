// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.BulkGetItemsWithVariantsAsync(new ItemWithVariantBulkGetRequestModel
{
    Variants = new List<VariantIdentifierModel>
    {
        new VariantIdentifierModel
        {
            Item = Reference.ById(new Guid("4b628214-e4fe-4fe0-b1ff-955df33e1515")),
            Language = Reference.ById(Guid.Empty)
        },
        new VariantIdentifierModel
        {
            Item = Reference.ById(new Guid("6a8b4d04-7d3e-4d3c-8b9a-4c7e8f9a1b2c")),
            Language = Reference.ByCodename("en-US")
        }
    }
});
