// DocSection: cm_api_v2_get_asset
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.viewAsset()
  .byAssetId('0270ea18-4842-4d09-9570-17b41bb37e2d')
  // .byAssetExternalId('which-brewing-fits-you')
  .toPromise();
// EndDocSection