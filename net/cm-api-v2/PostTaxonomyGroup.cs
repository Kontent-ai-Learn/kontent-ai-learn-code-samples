// DocSection: cm_api_v2_post_taxonomy_group
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var response = await client.CreateTaxonomyGroupAsync(new TaxonomyGroupCreateModel
{
    Name = "Personas",
    ExternalId = "Tax-Group-123",
    Codename = "people",
    Terms = new TaxonomyGroupCreateModel[]
    {
        new TaxonomyGroupCreateModel
        {
            Name = "Coffee expert",
            Codename = "expert",
            ExternalId = "Tax-term-456",
            Terms = new TaxonomyGroupCreateModel[]
            {
                new TaxonomyGroupCreateModel
                {
                    Name = "Barista",
                    ExternalId = "Tax-term-789",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "Cafe owner",
                    ExternalId = "Tax-term-101",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                }
            }
        },
        new TaxonomyGroupCreateModel
        {
            Name = "Coffee enthusiast",
            Codename = "enthusiast",
            ExternalId = "Tax-term-112",
            Terms = new TaxonomyGroupCreateModel[]
            {
                new TaxonomyGroupCreateModel
                {
                    Name = "Coffee lover",
                    ExternalId = "Tax-term-131",
                    Codename = "lover",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                },
                new TaxonomyGroupCreateModel
                {
                    Name = "Coffee blogger",
                    ExternalId = "Tax-term-145",
                    Codename = "blogger",
                    Terms = Enumerable.Empty<TaxonomyGroupCreateModel>()
                }
            }
        }
    }
});
// EndDocSection