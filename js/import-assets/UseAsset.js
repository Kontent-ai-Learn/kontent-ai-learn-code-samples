// DocSection: importing_assets_use_asset
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('ext-cafe-brno')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'photo'
      },
      value: [
        {
          external_id: "brno-cafe-image"
        }
      ]
    }
  ])
  .toPromise();
// EndDocSection