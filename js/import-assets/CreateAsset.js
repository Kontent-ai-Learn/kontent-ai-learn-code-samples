// DocSection: importing_assets_create_asset
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Uses the file reference object obtained in step 1
const response = await client.upsertAsset()
  .byAssetExternalId('brno-cafe-image')
  .withData(
    {
      file_reference: {
        id: '8660e19c-7bbd-48a3-bb51-721934c7756c',
        type: 'internal'
      },
      title: "Brno Cafe",
      descriptions: [
        {
          language: {
            codename: 'en-US'
          },
          description: 'Cafe in Brno'
        },
        {
          language: {
            codename: 'es-ES'
          },
          description: 'Café en Brno'
        }
      ]
    }
  )
  .toPromise();
// EndDocSection