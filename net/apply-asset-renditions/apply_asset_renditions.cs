// For other means of creating a client, see https://github.com/kontent-ai/delivery-sdk-net#setting-up-the-delivery-client
using var client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Retrieves a content item
var result = await client.GetItem<Article>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    // Gets the image from an asset element named Hero Image
    var imageWithRendition = result.Value.Elements.HeroImage?
        .SingleOrDefault(x => x.Name == "construction-insurance-header.jpg");

    if (imageWithRendition is not null
        && imageWithRendition.Renditions.TryGetValue("default", out var rendition))
    {
        // Combines the original image URL with the asset rendition query
        var assetUrl = $"{imageWithRendition.Url}?{rendition.Query}";
    }
}
