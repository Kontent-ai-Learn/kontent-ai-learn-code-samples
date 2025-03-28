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
                    ExternalId = "soccer",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
                },
                new TaxonomyTermCreateModel
                {
                    Name = "Ice hockey",
                    ExternalId = "hockey",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
                },
                new TaxonomyTermCreateModel
                {
                    Name = "Rugby",
                    ExternalId = "rugby",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
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
                    ExternalId = "js",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
                },
                new TaxonomyTermCreateModel
                {
                    Name = "C#",
                    ExternalId = "c",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
                },
                new TaxonomyTermCreateModel
                {
                    Name = "MVC",
                    ExternalId = "mvc",
                    Terms = Enumerable.Empty<TaxonomyTermCreateModel>()
                },
            }
        },
    }
});
