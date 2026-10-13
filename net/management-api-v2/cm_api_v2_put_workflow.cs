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

var identifier = Reference.ByCodename("my_workflow");
// var identifier = Reference.ById(Guid.Parse("f9f28df0-9dec-4ee3-b087-c501e4b75347"));

var response = (await client.UpdateWorkflowAsync(identifier, new WorkflowUpsertModel
{
    Name = "My updated workflow",
    Codename = "my_updated_workflow",
    Scopes =
    [
        new()
        {
            ContentTypes = [Reference.ByCodename("article")],
            Collections = [Reference.ByCodename("marketing")]
        }
    ],
    Steps =
    [
        new()
        {
            Name = "First step",
            Codename = "first_step",
            Color = WorkflowStepColor.SkyBlue,
            TransitionsTo =
            [
                new() { Step = Reference.ById(Guid.Parse("16221cc2-bd22-4414-a513-f3e555c0fc93")) },
                new() { Step = Reference.ByCodename("archived") }
            ],
            RoleIds = [Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b")]
        },
        new()
        {
            // Renames an existing step, identified by its ID
            Id = Guid.Parse("16221cc2-bd22-4414-a513-f3e555c0fc93"),
            Name = "Renamed Second step",
            Codename = "second_step_renamed",
            Color = WorkflowStepColor.Rose,
            TransitionsTo = [new() { Step = Reference.ByCodename("published") }]
        }
    ],
    PublishedStep = new WorkflowPublishedStepUpsertModel(),
    ArchivedStep = new WorkflowArchivedStepUpsertModel
    {
        RoleIds = [Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b")]
    }
})).EnsureSuccess();
