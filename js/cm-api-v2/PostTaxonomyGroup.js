// DocSection: cm_api_v2_post_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addTaxonomy()
  .withData(
    {
      name: "Personas",
      externalId: "Tax-Group-123",
      codename: "people",
      terms: [
        {
          name: "Coffee expert",
          externalId: "Tax-term-456",
          codename: "expert",
          terms: [
            {
              name: "Barista",
              externalId: "Tax-term-789",
              terms: []
            },
            {
              name: "Cafe owner",
              externalId: "Tax-term-101",
              terms: []
            }
          ]
        },
        {
          name: "Coffee enthusiast",
          codename: "enthusiast",
          externalId: "Tax-term-112",
          terms: [
            {
              name: "Coffee lover",
              codename: "lover",
              externalId: "Tax-term-131",
              terms: []
            },
            {
              name: "Coffee blogger",
              codename: "blogger",
              externalId: "Tax-term-145",
              terms: []
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