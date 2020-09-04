// DocSection: personalize_content_get_three_articles
import { RecommendationClient } from '@kentico/kontent-recommendations';

const client = new RecommendationClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_RECOMMENDATION_API_KEY>'
});

await client.recommendItems()
  .withData({
    visitId: 'visitorJohn', // Visitor identified as John
    currentItemCodename: 'caas', // Visitor is reading CaaS
    responseLimit: 3, // You want three recommendations
    requestedTypeCodename: 'blog_post' // You want articles
  }).toPromise();
// EndDocSection
