// Initializes a Delivery client
_client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
        .UseProductionApi()
        .Build())
    .Build();

// Retrieves a content item
var result = await _client.GetItem<Article>("my_article").ExecuteAsync();
if (!result.IsSuccess)
{
    return;
}

// Gets the image from an asset element named Teaser Image
var imageWithRendition = result.Value.Elements.TeaserImage?
    .SingleOrDefault(x => x.Name == "construction-insurance-header.jpg");
if (imageWithRendition is null)
{
    return;
}

// Gets the "default" asset rendition URL when available
if (!imageWithRendition.Renditions.TryGetValue("default", out var rendition))
{
    return;
}

var assetUrl = rendition.Url;