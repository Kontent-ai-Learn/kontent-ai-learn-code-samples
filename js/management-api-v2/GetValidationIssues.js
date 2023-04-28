// DocSection: mapi_v2_get_validation_issues
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.listEnvironmentValidationIssues()
  .byTaskId('15c68e60-dc30-4d34-a921-396563abd08d')
  .toPromise();
// EndDocSection