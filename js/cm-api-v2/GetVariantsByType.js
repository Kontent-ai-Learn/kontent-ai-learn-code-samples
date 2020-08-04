// DocSection: cm_api_v2_get_variants_of_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.listLanguageVariantsOfType()
  .byTypeCodename('article')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection