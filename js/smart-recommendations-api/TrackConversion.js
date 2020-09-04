// DocSection: rapi_v2_track_conversion
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { RecommendationClient } from '@kentico/kontent-recommendations';

// Creates an instance of the recommendation client
const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_SMART_RECOMMENDATION_API_KEY>'
});

// Tracks a conversion for a specific visitor and content item
await client.trackConversion()
    .withData({
        visitId: 'visitorId123',
        currentItemCodename: 'example_blog_post'
    }).toPromise();
// EndDocSection
