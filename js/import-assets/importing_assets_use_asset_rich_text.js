// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('new-cafes')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'body_copy'
      },
      value: "<p>...</p> <figure data-asset-external-id=\"brno-cafe-image\"></figure>"
    }
  ])
  .toPromise();
