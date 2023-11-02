// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('123')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'title'
      },
      value: 'On Roasts'
    },
    {
      element: {
        codename: 'related_articles'
      },
      value: [  
        {
          "external_id":"456"
        }
      ]
    }
  ])
  .toPromise();
