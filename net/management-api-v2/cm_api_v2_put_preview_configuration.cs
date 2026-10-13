// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;
using Kontent.Ai.Management.Configuration;
using Kontent.Ai.Management.Models.PreviewConfiguration;
using Kontent.Ai.Management.Models.Shared;

// Or register it through DI with services.AddManagementClient()
using var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = (await client.UpdatePreviewConfigurationAsync(new PreviewConfigurationModel
{
    SpaceDomains =
    [
        new SpaceDomainModel
        {
            Domain = "www.mysite.com",
            Space = Reference.ByCodename("my_space")
        }
    ],
    PreviewUrlPatterns =
    [
        new TypePreviewUrlPatternModel
        {
            ContentType = Reference.ByCodename("article"),
            UrlPatterns =
            [
                new PreviewUrlPatternModel
                {
                    Space = null,
                    UrlPattern = "https://www.globalsite.com/{URLSlug}"
                },
                new PreviewUrlPatternModel
                {
                    Space = Reference.ByCodename("my_space"),
                    UrlPattern = "https://{Space}/{URLSlug}/test"
                }
            ]
        }
    ]
})).EnsureSuccess();
