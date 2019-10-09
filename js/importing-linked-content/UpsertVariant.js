// DocSection: import_linked_upsert_variant
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertLanguageVariant()
  .byItemExternalId('123')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'title'
      },
      value: 'On Roasts'
    },
    {
      element: {
        codename: 'related_articles'
      },
      value: [  
        {
          "external_id":"456"
        }
      ]
    }
  ])
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection