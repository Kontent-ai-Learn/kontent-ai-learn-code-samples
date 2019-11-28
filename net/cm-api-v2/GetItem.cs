// DocSection: cm_api_v2_get_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

ManagementOptions options = new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ManagementClient client = new ManagementClient(options);

ContentItemIdentifier identifier = ContentItemIdentifier.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// ContentItemIdentifier identifier = ContentItemIdentifier.ByCodename("on_roasts");
// ContentItemIdentifier identifier = ContentItemIdentifier.ByExternalId("59713");

ContentItemModel responseItem = await client.GetContentItemAsync(identifier);
// EndDocSection