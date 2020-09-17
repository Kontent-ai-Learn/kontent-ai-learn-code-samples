// DocSection: personalize_content_get_three_articles
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.Models;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

// Creates a new recommendation request
var recommendationRequest = new RecommendationRequest {
        VisitId = "visitorJohn", // Visitor identified as John
        CurrentItemCodename = "caas", // Visitor is reading CaaS
        ResponseLimit = 3, // You want three recommendations
        RequestedTypeCodename = "article" // You want articles
};

// Gets the recommendations (codenames of the recommended items)
RecommendedContentItem[] recommendedArticles = await recommendationClient.GetRecommendationsAsync(recommendationRequest);
// EndDocSection