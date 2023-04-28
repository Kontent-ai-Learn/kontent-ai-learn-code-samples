// DocSection: cm_api_v2_get_taxonomy_groups
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listTaxonomies()
  .toPromise();

// Gets all pages of results
// const response = await client.listTaxonomies()
//   .toAllPromise();
// EndDocSection