// DocSection: recommendation_api_post_recommended_items
using Kentico.Kontent.Recommender;

RecommendationClient recommendationClient = new RecommendationClient("<YOUR_API_KEY>", timeout_seconds);
RecommendedContentItem[] recommendedArticles = await recommendationClient.GetRecommendationsAsync("item_codename_0", Request, Response, 3, "blog", sourceApp: "web");
// EndDocSection