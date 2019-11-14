// DocSection: cm_api_v2_put_item
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.ContentManagement;

ContentManagementOptions options = new ContentManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
};

ContentManagementClient client = new ContentManagementClient(options);

// Note: When creating a new item, use external ID as an identifier. When updating a content item, use any of the 3 identifiers below.
ContentItemIdentifier identifier = ContentItemIdentifier.ByExternalId("59713");
// ContentItemIdentifier identifier = ContentItemIdentifier.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// ContentItemIdentifier identifier = ContentItemIdentifier.ByCodename("on_roasts");

ContentItemUpdateModel itemToUpdate = new ContentItemUpdateModel()
{
    Name = "On Roasts",
  	SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") }
};

ContentItemUpsertModel itemToCreate = new ContentItemUpsertModel()
{
    Name = "On Roasts",
    // 'Type' is only required when creating a new content item
    Type = ContentTypeIdentifier.ByCodename("article"),
  	SitemapLocations = new[] { SitemapNodeIdentifier.ByCodename("articles") }
};

ContentItemModel updatedItemResponse = await client.UpdateContentItemAsync(identifier, itemToUpdate);
ContentItemModel createdItemResponse = await client.UpsertContentItemByExternalIdAsync(identifier, itemToCreate);
// EndDocSection