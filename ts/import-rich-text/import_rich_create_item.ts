// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.upsertContentItem()
  .byItemExternalId('simple-example')
  .withData(
    {
      name: 'Simple example',
      type: {
        external_id: 'simple-rich-text'
      }
    }
  )
  .toPromise();
