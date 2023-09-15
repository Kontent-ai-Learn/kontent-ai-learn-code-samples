// DocSection: cm_api_v2_post_workflow
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var secondStep = new WorkflowStepUpsertModel {
    Name = "Second step",
    CodeName = "second_step",
    Color = WorkflowStepColorModel.Rose,
    TransitionsTo = new [] {
        new WorkflowStepTransitionToUpsertModel {
            Step = Reference.ByCodename("published")
        },
    },
    RoleIds = new [] { Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b") }
};

var firstStep = new WorkflowStepUpsertModel {
    Name = "First step",
    CodeName = "first_step",
    Color = WorkflowStepColorModel.SkyBlue,
    TransitionsTo = new [] {
        new WorkflowStepTransitionToUpsertModel {
            Step = Reference.ByCodename(secondStep.CodeName),
        }
    },
    RoleIds = Array.Empty<Guid>()
};

var newWorkflow = new WorkflowUpsertModel
{
    Name = "My workflow",
    CodeName = "my_workflow",
    Scopes = new [] {
        new WorkflowScopeUpsertModel {
            ContentTypes = new [] {
                Reference.ById(Guid.Parse("1aeb9220-f167-4f8e-a7db-1bfec365fa80")),
                Reference.ByCodename("Article")
            },
            Collections = new [] {
                Reference.ById(Guid.Parse("b15b6050-80d8-406d-bf21-3012e4ad0ac5")),
                Reference.ByCodename("Marketing")
            }
        }
    },
    Steps = new [] {
        firstStep,
        secondStep,
    },
    PublishedStep = new WorkflowPublishedStepUpsertModel {
        RolesUnpublishArchivedCancelSchedulingIds = new [] { Guid.Parse("e796887c-38a1-4ab2-a999-c40861bb7a4b") },
        RoleCreateNewVersionIds = Array.Empty<Guid>()
    },
    ArchivedStep = new WorkflowArchivedStepUpsertModel {
        RoleIds = Array.Empty<Guid>()
    }
};

var response = await client.CreateWorkflowAsync(newWorkflow);
// EndDocSection