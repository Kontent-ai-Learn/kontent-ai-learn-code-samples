// DocSection: cm_api_v2_delete_asset
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteAsset()
  .byAssetId('1b458663-d23a-441c-8cc2-c2825fe53b48')
  // .byAssetExternalId('which-brewing-fits-you')
  .toPromise();
// EndDocSection