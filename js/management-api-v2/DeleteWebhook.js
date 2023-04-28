// DocSection: cm_api_v2_delete_webhook
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteWebhook()
  .byId("d53360f7-79e1-42f4-a524-1b53a417d03e")
  .toPromise();
// EndDocSection
