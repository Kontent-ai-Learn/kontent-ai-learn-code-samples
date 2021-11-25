// DocSection: importing_assets_use_asset
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertLanguageVariant()
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
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection