// DocSection: importing_create_item
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_MANAGEMENT_API_KEY>'
});

client.upsertContentItem()
  .byItemExternalId('ext-cafe-brno')
  .withData(
    {
      name: 'Brno',
      type: 'cafe'
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