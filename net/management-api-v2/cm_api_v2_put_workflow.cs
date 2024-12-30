// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var secondStep = new WorkflowStepUpsertModel {
    Name = "Renamed Second step",
    CodeName = "second_step_renamed",
    Color = WorkflowStepColorModel.Rose,
    Id = Guid.Parse("16221cc2-bd22-4414-a513-f3e555c0fc93"),
    TransitionsTo = new [] {
        new WorkflowStepTransitionToUpsertModel {
            Step = Reference.ByCodename("published")
        },
    },
    RoleIds = Array.Empty<Guid>(),
};

var firstStep = new WorkflowStepUpsertModel {
    Name = "First step",
    CodeName = "first_step",
    Color = WorkflowStepColorModel.SkyBlue,
    TransitionsTo = new [] {
        new WorkflowStepTransitionToUpsertModel {
            Step = Reference.ById(secondStep.Id.Value),
        },
        new WorkflowStepTransitionToUpsertModel {
            Step = Reference.ByCodename("archived"),
        }
    },
    RoleIds = new [] { Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b") }
};

var updatedWorkflow = new WorkflowUpsertModel
{
    Name = "My updated workflow",
    CodeName = "my_updated_workflow",
    Scopes = new [] {
        new WorkflowScopeUpsertModel {
            ContentTypes = new [] { Reference.ByCodename("article") },
            Collections = new [] { Reference.ByCodename("marketing") }
        }
    },
    Steps = new [] {
        firstStep,
        secondStep,
    },
    PublishedStep = new WorkflowPublishedStepUpsertModel {
        RolesUnpublishArchivedCancelSchedulingIds = Array.Empty<Guid>(),
        RoleCreateNewVersionIds = Array.Empty<Guid>()
    },
    ArchivedStep = new WorkflowArchivedStepUpsertModel {
        RoleIds =  new [] { Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b") }
    }
};

var identifier = Reference.ByCodename("my_workflow");
// var identifier = Reference.ById(Guid.Parse("f9f28df0-9dec-4ee3-b087-c501e4b75347"));

var response = await client.UpdateWorkflowAsync(identifier, updatedWorkflow);
