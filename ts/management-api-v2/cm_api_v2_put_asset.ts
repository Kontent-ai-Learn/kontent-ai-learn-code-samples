// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

// Updates an existing asset
const response = await client.updateAsset()
  .byAssetExternalId('which-brewing-fits-you')
  // .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  .withData((builder) => {
    return {
      title: 'Coffee Brewing Techniques',
      assetId: 'fcbb12e6-66a3-4672-85d9-d502d16b8d9c',
      descriptions: [
        {
          language: {
            codename: 'en-US'
          },
          description: 'Coffee Brewing Techniques'
        },
        {
          language: {
            codename: 'es-ES'
          },
          description: 'Técnicas para hacer café'
        }
      ],
      elements: [
        builder.taxonomyElement({
          element: {
            codename: 'taxonomy-categories'
          },
          value: [
            {
              codename: 'coffee'
            },
            {
              codename: 'brewing'
            }
          ]
        }),
      ]
    }
  })
  .toPromise();

// Creates a new asset or updates an existing one
const response = await client.upsertAsset()
  .byAssetExternalId('which-brewing-fits-you')
  // .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  .withData((builder) => {
    return {
      // 'file_reference' is only required when creating a new asset
      // To create a file reference, see the 'Upload a binary file' endpoint
      file_reference: {
        id: 'fcbb12e6-66a3-4672-85d9-d502d16b8d9c',
        type: 'internal'
      },
      title: 'Coffee Brewing Techniques',
      external_id: 'which-brewing-fits-you',
      descriptions: [
        {
          language: {
            codename: 'en-US'
          },
          description: 'Coffee Brewing Techniques'
        },
        {
          language: {
            codename: 'es-ES'
          },
          description: 'Técnicas para hacer café'
        }
      ],
      elements: [
        builder.taxonomyElement({
          element: {
            codename: 'taxonomy-categories'
          },
          value: [
            {
              codename: 'coffee'
            },
            {
              codename: 'brewing'
            }
          ]
        }),
      ]
    }
  })
  .toPromise();