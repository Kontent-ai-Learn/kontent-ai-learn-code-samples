// DocSection: import_linked_upsert_Sec_variant
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.upsertLanguageVariant()
  .byItemExternalId('456')
  .byLanguageCodename('en-US')
  .withElements([
    {
      element: {
        codename: 'title'
      },
      value: 'Donate with us'
    },
    {
      element: {
        codename: 'related_articles'
      },
      value: [  
        {
          "external_id":"123"
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