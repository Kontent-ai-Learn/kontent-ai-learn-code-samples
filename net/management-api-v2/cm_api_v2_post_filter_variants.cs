// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

// This endpoint is in early access and may evolve before general availability. 
// Use with caution in production environments.

// Filters variants by language only
var response = await client.EarlyAccess.FilterVariantsAsync(new VariantFilterRequestModel
{
    Filters = new VariantFilterFiltersModel
    {
        Language = Reference.ByCodename("en-US")
    }
});

// Filters variants with multiple criteria and includes element content
var response = await client.EarlyAccess.FilterVariantsAsync(new VariantFilterRequestModel
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
    },
    IncludeContent = true
});
