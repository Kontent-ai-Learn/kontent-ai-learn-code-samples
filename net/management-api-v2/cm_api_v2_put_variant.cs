// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    EnvironmentId = "KONTENT_AI_ENVIRONMENT_ID"
});

var identifier = new LanguageVariantIdentifier(Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474")), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ById(Guid.Parse("f4b3fc05-e988-4dae-9ac1-a94aba566474")), Reference.ByCodename("es-ES"));
// var identifier = new LanguageVariantIdentifier(Reference.ByCodename("my_article"), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ByCodename("my_article"), Reference.ByCodename("es-ES"));
// var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("59713"), Reference.ById(Guid.Parse("d1f95fde-af02-b3b5-bd9e-f232311ccab8")));
// var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("59713"), Reference.ByCodename("es-ES"));

var response = await client.UpsertLanguageVariantAsync(
    identifier,
    new LanguageVariantUpsertModel
    {
        Elements = ElementBuilder.GetElementsAsDynamic(new BaseElement[]
        {
            new TaxonomyElement
            {
                Element = Reference.ByCodename("personas"),
                Value = new []
                {
                    Reference.ByCodename("barista"),
                    Reference.ByCodename("coffee_blogger"),
                }
            },
            new DateTimeElement
            {
                Element = Reference.ByCodename("post_date"),
                Value = DateTime.Parse("2014-11-07T00:00:00Z"),
                DisplayTimeZone = "Australia/Sydney"
            },
            new TextElement
            {
                Element = Reference.ByCodename("summary"),
                Value = "Tostar granos de café puede tardar de 6 a 13 minutos. ..."
            },
            new LinkedItemsElement
            {
                Element = Reference.ByCodename("related_articles"),
                Value = new []
                {
                    Reference.ByCodename("coffee_processing_techniques"),
                    Reference.ByCodename("origins_of_arabica_bourbon"),
                }
            },
            new TextElement
            {
                Element = Reference.ByCodename("meta_keywords"),
                Value = "asados, café"
            },
            new TextElement
            {
                Element = Reference.ByCodename("meta_description"),
                Value = "Tostar granos de café puede tardar de 6 a 13 minutos. ..."
            },
            new UrlSlugElement
            {
                Element = Reference.ByCodename("url_pattern"),
                Mode = "autogenerated"
            },
        },
        DueDate = new DueDateModel
        {
            Value = DateTime.Parse("2024-02-26T06:04:00.7069564Z")
        },
        new WorkflowStepIdentifier(Reference.ByCodename("default"), Reference.ByCodename("review")))
    },
);
