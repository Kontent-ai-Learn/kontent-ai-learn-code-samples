// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.deleteAsset()
  .byAssetId('1b458663-d23a-441c-8cc2-c2825fe53b48')
  // .byAssetExternalId('which-brewing-fits-you')
  .toPromise();