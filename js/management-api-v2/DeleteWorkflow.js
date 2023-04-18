// DocSection: cm_api_v2_delete_workflow
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteWorkflow()
  .byWorkflowId("f9f28df0-9dec-4ee3-b087-c501e4b75347")
  //.byWorkflowCodename("my-workflow")
  .toPromise();
// EndDocSection
