// DocSection: rapi_v2_track_portion
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Tracks a partial view (10% in this case) of a content item
await recommendationClient.TrackPortionViewAsync("visitoriId123", "example_blog_post", 10);
// EndDocSection