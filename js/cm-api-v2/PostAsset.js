// DocSection: cm_api_v2_post_asset
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addAsset()
  .withData(
    {
      // To create a file reference, see the "Upload a binary file" endpoint
      fileReference: {
        id: 'fcbb12e6-66a3-4672-85d9-d502d16b8d9c',
        type: 'internal'
      },
      title: 'Coffee Brewing Techniques',
      externalId: 'which-brewing-fits-you',
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