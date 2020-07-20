// DocSection: cm_api_v2_get_variants_with_components_of_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.listLanguageVariantsOfContentTypeWithComponents()
  .byTypeCodename('coffee')
  //.byTypeID('929985ac-4aa5-436b-85a2-94c2d4fbbebd')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection