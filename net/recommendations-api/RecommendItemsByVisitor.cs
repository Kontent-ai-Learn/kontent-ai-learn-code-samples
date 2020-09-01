// DocSection: rapi_v2_recommend_by_visitor_context
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.Models;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<RECOMMENDATION_TOKEN>", timeoutSeconds: 5);

// Creates a new recommendation request
var recommendationRequest = new RecommendationRequest {
        VisitId = "visitorId123",
        CurrentItemCodename = "example_blogpost",
        ResponseLimit = 3,
        RequestedTypeCodename = "blog_post"
};

// Returns the requested number of recommended content items (their codenames)
RecommendedContentItem[] recommendedArticles = await recommendationClient.GetRecommendationsAsync(recommendationRequest);
// EndDocSection