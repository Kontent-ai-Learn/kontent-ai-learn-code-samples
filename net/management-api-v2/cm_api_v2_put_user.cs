// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.Users;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = UserIdentifier.ByEmail("user@kontent.ai");
//var identifier = UserIdentifier.ById("d94bc87a-c066-48a1-a910-4f991ccc1fb5");

var response = (await client.UpdateUserRolesAsync(
    identifier,
    new UserRolesUpdateModel
    {
        CollectionGroups =
        [
            new UserCollectionGroup
            {
                Collections = [Reference.ByDefaultId()],
                Roles =
                [
                    new UserRoleModel
                    {
                        Id = Guid.Parse("f58733b9-520b-406b-9d45-eb15a2baee96"),
                        Languages = [Reference.ByCodename("english")]
                    }
                ]
            }
        ]
    })).EnsureSuccess();
