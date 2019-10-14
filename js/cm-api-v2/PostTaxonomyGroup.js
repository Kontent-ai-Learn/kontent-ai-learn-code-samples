// DocSection: cm_api_v2_post_taxonomy_group
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addTaxonomy()
  .withData(
    {
      "name": "Personas",
      "externalId": "Tax-Group-123",
      "terms": [
        {
          "name": "Coffee expert",
          "externalId": "Tax-term-456",
          "terms": [
            {
              "name": "Barista",
              "externalId": "Tax-term-789",
              "terms": []
            },
            {
              "name": "Cafe owner",
              "externalId": "Tax-term-101",
              "terms": []
            }
          ]
        },
        {
          "name": "Coffee enthusiast",
          "externalId": "Tax-term-112",
          "terms": [
            {
              "name": "Coffee lover",
              "externalId": "Tax-term-131",
              "terms": []
            },
            {
              "name": "Coffee blogger",
              "externalId": "Tax-term-145",
              "terms": []
            }
          ]
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