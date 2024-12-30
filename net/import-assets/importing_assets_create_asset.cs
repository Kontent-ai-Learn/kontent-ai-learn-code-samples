// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

// Uses the file reference object obtained in step 1
var createdAssetResponse = await client.UpsertAssetAsync(Reference.ByExternalId("which-brewing-fits-you"), new AssetUpsertModel
{
    // 'fileReference' is only required when creating a new asset
    // To create a file reference, see the "Upload a binary file" endpoint
    FileReference = new FileReference
    {
        Id = "8660e19c-7bbd-48a3-bb51-721934c7756c",
        Type = FileReferenceTypeEnum.Internal
    },
    Title = "Brno Cafe",
    Descriptions = new AssetDescription[]
    {
        new AssetDescription
        {
            Description = "Cafe in Brno",
            Language = Reference.ByCodename("en-US")
        },
        new AssetDescription
        {
            Description = "Café en Brno",
            Language = Reference.ByCodename("es-ES")
        }
    }
});
