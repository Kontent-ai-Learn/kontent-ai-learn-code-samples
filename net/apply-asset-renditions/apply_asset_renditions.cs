// Initializes a Delivery client
_client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithEnvironmentId("KONTENT_AI_ENVIRONMENT_ID")
        .UseProductionApi()
        .Build())
    .Build();

// Retrieves a content item
var response = await _client.GetItemAsync<Article>("my_article");

// Gets the image from an asset element named Teaser Image
var imageWithRendition = response.Item.TeaserImage.SingleOrDefault(x => x.Name == "construction-insurance-header.jpg");

// Gets the asset rendition query from the image
var renditionQuery = imageWithRendition.Renditions["default"].Query;

// Combines the original image URL with the asset rendition query, if the image specifies a query
var assetUrl = $"{imageWithRenditions.Url}?{renditionQuery}";
