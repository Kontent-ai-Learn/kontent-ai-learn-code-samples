// DocSection: cm_api_v2_get_webhook
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.getWebhook()
  .byId("5df74e27-1213-484e-b9ae-bcbe90bd5990")
  .toPromise();
// EndDocSection
