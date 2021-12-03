// DocSection: importing_assets_use_asset_rich_text
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
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
// EndDocSection