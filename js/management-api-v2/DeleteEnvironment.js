// DocSection: cm_api_v2_delete_environment
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    projectId: '<YOUR_PROJECT_ID>',
    apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteEnvironment()
    .toPromise();
// EndDocSection
