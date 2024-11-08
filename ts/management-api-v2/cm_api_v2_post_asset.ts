// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.addAsset()
  .withData((builder) => {
    return {
      // To create a file reference, check the 'Upload a binary file' endpoint
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