// DocSection: cm_api_v2_get_components_of_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.listLanguageVariantsOfContentTypeWithComponents()
  .byTypeID('6434e475-5a29-4866-9fd1-6d1ca873f5be')
  //.byTypeCodename('article')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection
