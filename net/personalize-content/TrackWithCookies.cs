// DocSection: personalize_content_cookie_helper
using Kentico.Kontent.Recommendations;
using Kentico.Kontent.Recommendations.CookieHelper;

// Tries to get a cookie, which stores the visitId
var cookie = RecommendationCookieHelper.GetRecommendationTrackingCookie(Request);

// If there's no cookie, the visitor is new and without a visitId
if (cookie == null)
{
    // Creates a new tracking cookie for the visitor
    cookie = RecommendationCookieHelper.SetNewRecommendationTrackingCookie(Request, Response);
}

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

await recommendationClient.CreateVisitorAsync(
    cookie.VisitId, // Provides the generated visitId
    cookie.GetVisitorDetails(Request) // Provides IP address and referrer
    );
// EndDocSection