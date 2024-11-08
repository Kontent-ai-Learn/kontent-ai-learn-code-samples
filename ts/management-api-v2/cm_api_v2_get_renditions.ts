// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

// Gets the first page of results
const response = await client.listAssetRenditions()
  .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  // .byAssetExternalId('which-brewing-fits-you')
  .toPromise();