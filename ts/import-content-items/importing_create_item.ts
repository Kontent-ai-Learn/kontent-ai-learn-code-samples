// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
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
