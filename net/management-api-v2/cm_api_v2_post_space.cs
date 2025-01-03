// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CreateSpaceAsync(new SpaceCreateModel
    {
        Name = "Space 1", 
        Codename = "space_1",
        WebSpotlightRootItem = Reference.ByCodename("root_item_1"),
        Collections = new Reference[] {
            Reference.ByCodename("first_collection"), Reference.ByExternalId("external-collection")
        }
    }
);
