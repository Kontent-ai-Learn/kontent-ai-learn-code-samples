// DocSection: import_linked_create_sec_item
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertContentItem()
  .byItemExternalId('456')
  .withData(
    {
      name: 'Donate with us',
      type: 'article'
    }
  )
  .toPromise();
// EndDocSection