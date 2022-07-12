// DocSection: import_model_create_taxonomy
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = client.addTaxonomy()
  .withData(
    {
      name: 'Blogpost topic',
      codename: 'blog_topic',
      terms: [
        {
          name: 'Sport',
          codename: 'sport',
          terms: [
            {
              name: 'Soccer',
              codename: 'soccer',
              terms: []
            },
            {
              name: 'Ice hockey',
              codename: 'hockey',
              terms: []
            },
            {
              name: 'Rugby',
              codename: 'rugby',
              terms: []
            }
          ]
        },
        {
          name: "Technology stack",
          codename: "tech",
          terms: [
            {
              name: "JavaScript",
              codename: "js",
              terms: []
            },
            {
              name: "C#",
              codename: "c",
              terms: []
            },
            {
              name: 'MVC',
              codename: 'mvc',
              terms: []
            }
          ]
        }
      ]
    }
  )
  .toPromise();
// EndDocSection
