// DocSection: rapi_v2_track_partial_view
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<RECOMMENDATION_TOKEN>", timeoutSeconds: 5);

// Tracks a partial view (10% in this case) of a content item
await recommendationClient.TrackPortionViewAsync("visitoriId123", "example_blog_post", 10);
// EndDocSection