// DocSection: rapi_v2_recommend_by_visitor_context
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { RecommendationClient } from '@kentico/kontent-recommendations';

// Creates an instance of the recommendation client
const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_SMART_RECOMMENDATION_API_KEY>'
});

// Creates a recommendation request
await client.recommendItems()
  .withData({
    currentItemCodename: 'example_blogpost',
    requestedTypeCodename: 'blog_post',
    responseLimit: 3,
    visitId: 'visitorId123',
    recommendationSettings: {
      filter: '"persona=developer" in \'properties\'',
      booster: 'if 'lastupdated' >= now() - 259200000  then 2 else 1',
      scenario: 'popular'
    },
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
