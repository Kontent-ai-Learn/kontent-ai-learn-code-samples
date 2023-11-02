// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var identifier = UserIdentifier.ByEmail("user@kontent.ai");
//var identifier = UserIdentifier.ById("d94bc87a-c066-48a1-a910-4f991ccc1fb5");

var response = await client.ModifyUsersRolesAsync(
    identifier,
    new UserModel
    {
        CollectionGroup = new List<UserCollectionGroup>
        {
            new UserCollectionGroup
            {
                Collections = new List<Reference>
                {
                    Reference.ById(Guid.Empty),
                },
                Roles = new List<Role>
                {
                    new Role
                    {
                        Id = Guid.Parse("f58733b9-520b-406b-9d45-eb15a2baee96"),
                        Languages = new List<Reference>() { Reference.ByCodename("english") }
                    }
                }
            }
        }
    });
