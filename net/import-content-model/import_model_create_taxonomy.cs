// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "KONTENT_AI_MANAGEMENT_API_KEY",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var response = await client.CreateTaxonomyGroupAsync(new TaxonomyGroupCreateModel
{
    Name = "Blogpost topic",
    Codename = "blog_topic",
    Terms = new TaxonomyTermCreateModel[]
    {
        new TaxonomyTermCreateModel
        {
            Name = "Sport",
            Codename = "sport",
            Terms = new TaxonomyTermCreateModel[]
            {
                new TaxonomyTermCreateModel
                {
                    Name = "Soccer",
                    ExternalId = "soccer"
                },
                new TaxonomyTermCreateModel
                {
                    Name = "Ice hockey",
                    ExternalId = "hockey"
                },
                new TaxonomyTermCreateModel
                {
                    Name = "Rugby",
                    ExternalId = "rugby"
                },
            }
        },
        new TaxonomyTermCreateModel
        {
            Name = "Technology stack",
            Codename = "tech",
            Terms = new TaxonomyTermCreateModel[]
            {
                new TaxonomyTermCreateModel
                {
                    Name = "Javascript",
                    ExternalId = "js"
                },
                new TaxonomyTermCreateModel
                {
                    Name = "C#",
                    ExternalId = "c"
                },
                new TaxonomyTermCreateModel
                {
                    Name = "MVC",
                    ExternalId = "mvc"
                },
            }
        },
    }
});
