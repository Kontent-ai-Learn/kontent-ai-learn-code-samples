// DocSection: cm_api_v2_put_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Updates an existing content item
const response = await client.updateContentItem()
  .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  // .byItemCodename('my_article')
  // .byItemExternalId('59713')
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article'
    }
  )
  .toPromise();

// Creates a new content item
const response = await client.upsertContentItem()
  .byItemExternalId('59713')
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      // 'type' is only required when creating a new content item
      type: 'article'
    }
  )
  .toPromise();
// EndDocSection