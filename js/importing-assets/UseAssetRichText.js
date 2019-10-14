// DocSection: importing_assets_use_asset_rich_text
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertLanguageVariant()
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
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection