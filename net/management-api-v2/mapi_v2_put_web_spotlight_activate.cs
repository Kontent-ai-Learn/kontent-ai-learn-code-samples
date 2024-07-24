// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var reference = Reference.ById(Guid.Parse("6291c693-f6e4-4a6b-ac67-5c31c32f9388"));
// var reference = Reference.ById("my_web_root_type");

var model = new WebSpotlightActivateModel()
{
    RootType = reference
}

var response = await client.ActivateWebSpotlightAsync(model);