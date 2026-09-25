// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.ItemWithVariant;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.VariantFilter;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

// Filters variants by language only
IReadOnlyList<ItemWithVariantFilterResultModel> variantsInLanguage = (await client.FilterItemsWithVariantsAsync(new ItemWithVariantFilterRequestModel
{
    Filters = new VariantFilterFiltersModel
    {
        Language = Reference.ByCodename("en-US")
    }
})).EnsureSuccess();

// Filters variants with multiple criteria
IReadOnlyList<ItemWithVariantFilterResultModel> filteredVariants = (await client.FilterItemsWithVariantsAsync(new ItemWithVariantFilterRequestModel
{
    Filters = new VariantFilterFiltersModel
    {
        SearchPhrase = "test",
        Language = Reference.ByCodename("en-US"),
        ContentTypes = [Reference.ByCodename("article")],
        CompletionStatuses = [VariantFilterCompletionStatus.AllDone]
    },
    Order = new VariantFilterOrderModel
    {
        By = VariantFilterOrderColumn.Name,
        Direction = VariantFilterOrderDirection.Ascending
    }
})).EnsureSuccess();
