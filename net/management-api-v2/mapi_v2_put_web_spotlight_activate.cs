// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var reference = Reference.ByCodename("custom_web_spotlight_root");
// var reference = Reference.ById(Guid.Parse("6291c693-f6e4-4a6b-ac67-5c31c32f9388"));
// var reference = Reference.ByExternalId("custom-root-type");

var model = new WebSpotlightActivateModel()
{
    RootType = reference
}

var response = await client.ActivateWebSpotlightAsync(model);