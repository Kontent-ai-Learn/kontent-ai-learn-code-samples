// Create a delivery client using the builder pattern
using var clientContainer = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("your-environment-id")
        .UseProductionApi()
        .Build())
    .Build();

// Get the client from the container
var client = clientContainer.Client;

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
