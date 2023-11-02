// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Used when updating an existing item
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


// Used when creating a new asset or updating an existing one
const response = await client.upsertAsset()
  .byAssetExternalId('which-brewing-fits-you')
  // .byAssetId('fcbb12e6-66a3-4672-85d9-d502d16b8d9c')
  .withData((builder) => {
    return {
      // 'file_reference' is only required when creating a new asset
      // To create a file reference, see the "Upload a binary file" endpoint
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
