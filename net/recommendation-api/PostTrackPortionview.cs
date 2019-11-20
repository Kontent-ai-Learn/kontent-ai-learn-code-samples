// DocSection: recommendation_api_post_track_portionview
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using Kentico.Kontent.Recommender;

RecommendationClient recommendationClient = new RecommendationClient("<YOUR_API_KEY>", timeout_seconds);

CallerInfo callerInfo = new CallerInfo {
    Ip = "127.0.0.1",
    SourceApp = "web"
};

await recommendationClient.TrackVisitAsync("visitor01", "item_codename_0", 20, callerInfo);
// EndDocSection