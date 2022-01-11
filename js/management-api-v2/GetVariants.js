// DocSection: cm_api_v2_get_variants
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listLanguageVariantsOfItem()
  .byItemId('f4b3fc05-e988-4dae-9ac1-a94aba566474')
  // .byItemCodename('my_article')
  // .byItemExternalId('59713')
  .toPromise();

// Gets all pages of results
// const response = await client.listLanguageVariantsOfItem()
//   .byItemCodename('my_article')
//   .toAllPromise();
// EndDocSection