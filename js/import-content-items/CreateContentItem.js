// DocSection: importing_create_item
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_MANAGEMENT_API_KEY>'
});

const response = await client.upsertContentItem()
  .byItemExternalId('ext-cafe-brno')
  .withData(
    {
      name: 'Brno',
      type: 'cafe'
    }
  )
  .toPromise();
// EndDocSection