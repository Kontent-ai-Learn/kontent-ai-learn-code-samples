// DocSection: cm_api_v2_post_rendition
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addAssetRendition()
  .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  // .byAssetExternalId('which-brewing-fits-you')
  .withData({
    external_id: 'hero-image-rendition',
    transformation: {
      fit: 'clip',
      mode: 'rect',
      height: 120,
      width: 240,
      x: 300,
      y: 200,
      custom_height: 360,
      custom_width: 720
    }
  })
  .toPromise();
// EndDocSection
