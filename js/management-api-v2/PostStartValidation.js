// DocSection: cm_api_v2_post_start_validation
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client
.startEnvironmentValidation()
.byTaskId('15c68e60-dc30-4d34-a921-396563abd08d')
.toPromise()
//EndDocSection
