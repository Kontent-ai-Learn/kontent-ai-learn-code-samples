// DocSection: cm_api_v2_get_components_of_type
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>,
  apiKey: '<YOUR_API_KEY>'
});

// Gets the first page of results
const response = await client.listLanguageVariantsOfContentTypeWithComponents()
  .byTypeID('6434e475-5a29-4866-9fd1-6d1ca873f5be')
//   .byTypeCodename('article')
  .toPromise();

// Gets all pages of results
// const response = await client.listLanguageVariantsOfContentTypeWithComponents()
//   .byTypeCodename('article')
//   .toAllPromise();
// EndDocSection
