// DocSection: cm_api_v2_get_workflows
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.listWorkflows()
  .toPromise();
// EndDocSection