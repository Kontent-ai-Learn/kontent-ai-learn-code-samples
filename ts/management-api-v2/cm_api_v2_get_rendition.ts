// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.viewAssetRendition()
  .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  // .byAssetExternalId('which-brewing-fits-you')
  .byRenditionId('ce559491-0fc1-494b-96f3-244bc095de57')
  // .byRenditionExternalId('hero-image-rendition')
  .toPromise();