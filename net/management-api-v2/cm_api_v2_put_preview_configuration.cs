// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.UpdatePreviewConfigurationAsync(new PreviewConfigurationModel()
    {
        SpaceDomains = new List<SpaceDomainModel>
        {
            new()
            {
                Domain = "www.mysite.com",
                Space = Reference.ByCodename("my_space")
            }
        },
        PreviewUrlPatterns = new List<TypePreviewUrlPatternModel>
        {
            new()
            {
                ContentType = Reference.ByCodename("article"),
                UrlPatterns = new List<PreviewUrlPatternModel>
                {
                    new()
                    {
                        Space = null,
                        UrlPattern = "https://www.globalsite.com/{URLSlug}"
                    },
                    new()
                    {
                        Space = Reference.ByCodename("my_space"),
                        UrlPattern = "https://{Space}/{URLSlug}/test"
                    },

                }
            }
        }
    }
);
