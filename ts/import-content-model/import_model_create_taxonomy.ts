// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
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
          name: 'Technology stack',
          codename: 'tech',
          terms: [
            {
              name: 'JavaScript',
              codename: 'js',
              terms: []
            },
            {
              name: 'C#',
              codename: 'c',
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