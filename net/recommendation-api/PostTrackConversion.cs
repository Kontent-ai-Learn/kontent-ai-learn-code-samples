// DocSection: recommendation_api_post_track_conversion
using Kentico.Kontent.Recommender;

RecommendationClient recommendationClient = new RecommendationClient("<YOUR_API_KEY>", timeout_seconds);

CallerInfo callerInfo = new CallerInfo {
    Ip = "127.0.0.1",
    SourceApp = "web"
};

await recommendationClient.TrackConversionAsync("visitor01", "item_codename_0", callerInfo);
// EndDocSection