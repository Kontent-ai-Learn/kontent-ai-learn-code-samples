// DocSection: rapi_v2_track_conversion
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Tracks a conversion for a specific visitor and content item
await recommendationClient.TrackConversionAsync("visitoriId123","example_blog_post");
// EndDocSection