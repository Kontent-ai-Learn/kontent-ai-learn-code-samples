// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.cloneEnvironment()
  .withData(
    {
      name: 'Develop',
      roles_to_activate: ['ee483b59-5a24-4010-b277-ae224c34bc71'],
      copy_data_options: {
        content_items_assets: true,
        content_item_version_history: false,
      }
    }
  )
  .toPromise();