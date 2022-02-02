// DocSection: rapi_v2_track_visit
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Track a visit (a view by a specific visitor) for a content item
await recommendationClient.TrackVisitAsync("visitoriId123", "example_blog_post");
// EndDocSection