// DocSection: cm_api_v2_delete_item
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.deleteContentItem()
  .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  // .byItemCodename('on_roasts')
  // .byItemExternalId('59714')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection