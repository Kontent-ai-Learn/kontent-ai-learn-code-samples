// DocSection: cm_api_v2_put_asset
// Using ES6 syntax
import { ContentManagementClient } from '@kentico/kontent-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Used when updating an existing item
client.updateAsset()
  .withData(
    {
      title: "Coffee Brewing Techniques",
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
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });


// Used when creating a new asset or updating an existing one
client.upsertAsset()
  .withData(
    {
      // 'fileReference' is only required when creating a new asset
      // To create a file reference, see the "Upload a binary file" endpoint
      fileReference: {
        id: 'fcbb12e6-66a3-4672-85d9-d502d16b8d9c',
        type: 'internal'
      },
      title: "Coffee Brewing Techniques",
      assetExternalId: 'which-brewing-fits-you',
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
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection