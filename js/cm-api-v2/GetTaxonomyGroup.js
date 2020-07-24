// DocSection: cm_api_v2_get_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.getTaxonomy()
  .byTaxonomyCodename("categories")
  //.byTaxonomyID("bef9dd62-a3b8-4146-83e4-33be707899b4")
  //.byTaxonomyExternalID("my-little-taxopony")
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection
