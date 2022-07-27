// DocSection: cm_api_v2_delete_type
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteContentType()
  .byTypeId('269202ad-1d9d-47fd-b3e8-bdb05b3e3cf0')
  // .byTypeCodename('hosted_video')
  .toPromise();
// EndDocSection