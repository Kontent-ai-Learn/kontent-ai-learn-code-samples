// DocSection: cm_api_v2_post_item
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentItem()
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      type: {
        codename: 'article'
      },
      external_id: '59713'
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection
