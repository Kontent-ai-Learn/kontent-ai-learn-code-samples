// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.viewAsset()
  .byAssetId('0270ea18-4842-4d09-9570-17b41bb37e2d')
  // .byAssetExternalId('which-brewing-fits-you')
  .toPromise();
