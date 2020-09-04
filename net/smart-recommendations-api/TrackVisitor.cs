// DocSection: rapi_v2_track_visitor
using Kentico.Kontent.Recommendations;

// Creates an instance of the recommendation client
var recommendationClient = new RecommendationClient(accessToken: "<YOUR_RECOMMENDATION_API_KEY>", timeoutSeconds: 5);

var visitor = new VisitorDetails {
    // Provide IP if you enabled Geolocation
    Ip = "192.166.12.4",
    Referer = "https://www.google.com/search?hl=en&q=kentico%20kontent",
    // Provide Location if you disabled Geolocation
    Location = new LocationDetails {
        City = "Brno",
        Country = "Czech Republic",
        Timezone = "CET"
    }
};

// Creates a visitor profile in Smart Recommendations
await recommendationClient.CreateVisitorAsync("clientId", visitor);
// EndDocSection
