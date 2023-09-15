// DocSection: cm_api_v2_post_space
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.CreateSpaceAsync(new SpaceCreateModel
    {
        Name = "Space 1", 
        Codename = "space_1",
        WebSpotlightRootItem = Reference.ByCodename("root_item_1")
    }
);
// EndDocSection