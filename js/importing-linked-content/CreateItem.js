// DocSection: import_linked_create_item
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertContentItem()
  .byItemExternalId('123')
  .withData(
    {
      name: 'On Roasts',
      type: 'article'
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection