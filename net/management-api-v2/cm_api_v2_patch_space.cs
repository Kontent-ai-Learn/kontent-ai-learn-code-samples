// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = Reference.ById(Guid.Parse("6291c693-f6e4-4a6b-ac67-5c31c32f9388"));
// var identifier = Reference.ByCodename("space_1");

var response = await client.ModifySpaceAsync(identifier, new SpaceOperationReplaceModel[]
    {
        new SpaceOperationReplaceModel
        {
            PropertyName = PropertyName.Name,
            Value = "New space name"
        },
        new SpaceOperationReplaceModel
        {
            PropertyName = PropertyName.Codename,
            Value = "new_space_codename"
        },
        new SpaceOperationReplaceModel
        {
            PropertyName = PropertyName.WebSpotlightRootItem,
            Value = Reference.ById(Guid.Parse("1024356f-858f-421a-b804-07c6bfe10ce5"))
        } 
    }
);
