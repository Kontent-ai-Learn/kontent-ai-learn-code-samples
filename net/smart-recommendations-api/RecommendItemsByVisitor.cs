// DocSection: rapi_v2_recommend_by_visitor_context
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.Models;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Defines last 30 days in milliseconds
var lastMonth = TimeSpan.FromDays(30).Milliseconds;

// Uses filtering and boosting for more specific recommendations
var recommendationSettings = new RecommendationSettings
{
    // Queries items with value 'developer' in element 'persona'
    Filter = "\"persona=developer\" in 'properties'",
    // Boosts items updated in last 30 days (twice as likely to recommend)
    Booster = $"if 'lastupdated' >= now() - {lastMonth} then 2 else 1",
    Scenario = "popular"
};

var visitor = new VisitorDetails
{
    // Provide IP if you enabled Geolocation
    Ip = "192.166.12.4",
    Referer = "google.com",
    // Provide Location if you disabled Geolocation
    Location = new LocationDetails
    {
        City = "Brno",
        Country = "Czech Republic",
        Timezone = "CET"
    }
};

// Creates a new recommendation request
var recommendationRequest = new RecommendationRequest
{
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