// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.viewContentTypeSnippet()
  .byTypeId('269202ad-1d9d-47fd-b3e8-bdb05b3e3cf0')
  // .byTypeCodename('hosted_video')
  // .byTypeExternalId('snippet-type-123')
  .toPromise();
