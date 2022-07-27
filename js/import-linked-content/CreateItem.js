// DocSection: import_linked_create_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.upsertContentItem()
  .byItemExternalId('123')
  .withData(
    {
      name: 'On Roasts',
      type: 'article'
    }
  )
  .toPromise();
// EndDocSection