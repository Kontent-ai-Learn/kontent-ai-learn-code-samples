// DocSection: rapi_v2_track_portion
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { RecommendationClient } from '@kentico/kontent-recommendations';

// Creates an instance of the recommendation client
const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_SMART_RECOMMENDATION_API_KEY>'
});

// Tracks a partial view (10% in this case) of a content item
await client.trackPortion()
  .withData({
    visitId: 'visitorId123',
    currentItemCodename: 'example_blog_post',
    portionPercentage: 10
  }).toPromise();
// EndDocSection
