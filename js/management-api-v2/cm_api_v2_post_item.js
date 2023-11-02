// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addContentItem()
  .withData(
    {
      name: 'On Roasts',
      codename: 'my_article_my_article',
      type: {
        codename: 'article'
      },
      collection: {
        codename: 'default'
      },
      external_id: '59713'
    }
  )
  .toPromise();
