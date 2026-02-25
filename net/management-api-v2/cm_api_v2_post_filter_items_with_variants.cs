// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

// Filters variants by language only
var response = await client.FilterItemsWithVariantsAsync(new ItemWithVariantFilterRequestModel
{
    Filters = new VariantFilterFiltersModel
    {
        Language = Reference.ByCodename("en-US")
    }
});

// Filters variants with multiple criteria
var response = await client.FilterItemsWithVariantsAsync(new ItemWithVariantFilterRequestModel
{
    Filters = new VariantFilterFiltersModel
    {
        SearchPhrase = "test",
        Language = Reference.ByCodename("en-US"),
        ContentTypes = new List<Reference>
        {
            Reference.ByCodename("article")
        },
        CompletionStatuses = new List<VariantFilterCompletionStatus> 
        { 
            VariantFilterCompletionStatus.Completed 
        }
    },
    Order = new VariantFilterOrderModel
    {
        By = "name",
        Direction = VariantFilterOrderDirection.Ascending
    }
});
