// DocSection: rapi_v2_track_visitor
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.Models;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

var visitor = new VisitorDetails {
    // Provide IP if you enabled Geolocation
    Ip = "192.166.12.4",
    Referer = "google.com",
    // Provide Location if you disabled Geolocation
    Location = new LocationDetails {
        City = "Brno",
        Country = "Czech Republic",
        Timezone = "CET"
    }
};

// Creates a new recommendation request
var recommendationRequest = new RecommendationRequest {
    VisitId = "visitorId123",
    CurrentItemCodename = "example_blogpost",
    ResponseLimit = 3,
    RequestedTypeCodename = "blog_post",
    RecommendationSettings = recommendationSettings,
    Visitor = visitor
};

// Returns the requested number of recommended content items (their codenames)
RecommendedContentItem[] recommendedArticles = await recommendationClient.GetRecommendationsAsync(recommendationRequest);
// EndDocSection