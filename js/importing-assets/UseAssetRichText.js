// DocSection: importing_assets_use_asset_rich_text
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
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