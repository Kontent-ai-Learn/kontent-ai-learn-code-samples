// DocSection: cm_api_v2_get_asset
// Using ES6 syntax
import { ContentManagementClient } from '@kentico/kontent-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.viewAsset()
  .byAssetId('0270ea18-4842-4d09-9570-17b41bb37e2d')
  // .byAssetExternalId('which-brewing-fits-you')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection