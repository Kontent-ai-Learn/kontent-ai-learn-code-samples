// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.Workflow;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.CreateWorkflowAsync(new WorkflowUpsertModel
{
    Name = "My workflow",
    Codename = "my_workflow",
    Scopes =
    [
        new()
        {
            ContentTypes = [Reference.ById(Guid.Parse("1aeb9220-f167-4f8e-a7db-1bfec365fa80")), Reference.ByCodename("article")],
            Collections = [Reference.ById(Guid.Parse("b15b6050-80d8-406d-bf21-3012e4ad0ac5")), Reference.ByCodename("marketing")]
        }
    ],
    Steps =
    [
        new()
        {
            Name = "First step",
            Codename = "first_step",
            Color = WorkflowStepColor.SkyBlue,
            TransitionsTo = [new() { Step = Reference.ByCodename("second_step") }]
        },
        new()
        {
            Name = "Second step",
            Codename = "second_step",
            Color = WorkflowStepColor.Rose,
            TransitionsTo = [new() { Step = Reference.ByCodename("published") }],
            RoleIds = [Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b")]
        }
    ],
    PublishedStep = new WorkflowPublishedStepUpsertModel
    {
        UnpublishRoleIds = [Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b")]
    },
    ArchivedStep = new WorkflowArchivedStepUpsertModel()
})).EnsureSuccess();
