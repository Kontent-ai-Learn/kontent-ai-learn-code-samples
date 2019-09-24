// DocSection: cm_api_v2_get_assets
// Using ES6 syntax
import { ContentManagementClient } from '@kentico/kontent-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.listAssets()
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection