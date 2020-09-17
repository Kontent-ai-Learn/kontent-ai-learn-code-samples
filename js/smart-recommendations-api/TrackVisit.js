// DocSection: rapi_v2_track_visit
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { RecommendationClient } from '@kentico/kontent-recommendations';

// Creates an instance of the recommendation client
const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_SMART_RECOMMENDATION_API_KEY>'
});

// Track a visit (a view by a specific visitor) for a content item
await client.trackVisit()
    .withData({
        visitId: 'visitorId123',
        currentItemCodename: 'example_blog_post'
    }).toPromise();
// EndDocSection
