// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.InviteUserIntoProjectAsync(new UserInviteModel
{
    CollectionGroup = new List<UserCollectionGroup>
    {
        new UserCollectionGroup
        {
            Collections = new List<Reference>
            {
                Reference.ById(Guid.Empty),
                Reference.ById(Guid.Parse("28b68213-d636-4b01-9fd1-988b93789e17"))
            },
            Roles = new List<Role>
            {
                new Role
                {
                    Id = Guid.Parse("f58733b9-520b-406b-9d45-eb15a2baee96"),
                    Languages = new List<Reference>() { Reference.ById(Guid.Parse("7df9a691-cf29-402d-9598-66273e7561b7")) }
                }
            }
        }
    }
});
