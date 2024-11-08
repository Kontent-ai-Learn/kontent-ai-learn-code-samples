// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.deleteWorkflow()
  .byWorkflowId('f9f28df0-9dec-4ee3-b087-c501e4b75347')
  //.byWorkflowCodename('my-workflow')
  .toPromise();