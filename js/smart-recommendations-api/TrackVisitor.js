// DocSection: rapi_v2_track_visitor
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { RecommendationClient } from '@kentico/kontent-recommendations';

// Creates an instance of the recommendation client
const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_SMART_RECOMMENDATION_API_KEY>'
});

// Creates a visitor profile in Smart Recommendations
await client.trackVisitor()
  .withData({
    visitId: 'visitorId123',
    visitor: {
      ip: '192.166.12.4',
      referer: 'https://www.google.com/search?hl=en&q=kentico%20kontent',
      location: {
        city: 'Brno',
        country: 'Czech Republic',
        timezone: 'CET'
      },
      custom: {
        persona: 'developer'
      }
    }
  }).toPromise();
// EndDocSection
