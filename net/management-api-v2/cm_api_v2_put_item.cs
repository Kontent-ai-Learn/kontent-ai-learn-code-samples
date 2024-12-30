// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = Reference.ByExternalId("59713");
// var identifier = Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474"));
// var identifier = Reference.ByCodename("my_article");
var upsertedItemResponse = await client.UpsertContentItemAsync(identifier, new ContentItemUpsertModel
{
    Name = "On Roasts",
    Codename = "my_article_my_article",
    Collection = Reference.ByCodename("default"),
    // 'Type' is only required when creating a new content item
    Type = Reference.ByCodename("article"),
});
