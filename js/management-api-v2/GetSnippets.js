// DocSection: cm_api_v2_get_snippets
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listContentTypeSnippets()
  .toPromise();

// Gets all pages of results
// const response = await client.listContentTypeSnippets()
//   .toAllPromise();
// EndDocSection