// DocSection: cm_api_v2_get_types
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listContentTypes()
  .toPromise();

// Gets all pages of results
// const response = await client.listContentTypes()
//   .toAllPromise();
// EndDocSection
