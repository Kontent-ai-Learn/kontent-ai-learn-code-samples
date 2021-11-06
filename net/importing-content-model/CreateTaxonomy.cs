// DocSection: import_model_create_taxonomy
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateTaxonomyGroupAsync(new TaxonomyGroupCreateModel
{
    Name = "Blogpost topic",
    Codename = "blog_topic",
    Terms = new TaxonomyGroupCreateModel[]
    {
        new TaxonomyGroupCreateModel
        {
            Name = "Sport",
            Codename = "sport",
            Terms = new TaxonomyGroupCreateModel[]
            {
                new TaxonomyGroupCreateModel
                {
                    Name = "Soccer",
                    ExternalId = "soccer",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "Ice hockey",
                    ExternalId = "hockey",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "Rugby",
                    ExternalId = "rugby",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
            }
        },
        new TaxonomyGroupCreateModel
        {
            Name = "Technology stack",
            Codename = "tech",
            Terms = new TaxonomyGroupCreateModel[]
            {
                new TaxonomyGroupCreateModel
                {
                    Name = "Javascript",
                    ExternalId = "js",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "C#",
                    ExternalId = "c",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "MVC",
                    ExternalId = "mvc",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
            }
        },
    }
});
// EndDocSection
