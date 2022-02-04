// DocSection: cm_api_v2_delete_snippet
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteContentTypeSnippet()
  .byTypeId('baf884be-531f-441f-ae88-64205efdd0f6')
  // .byTypeCodename('metadata')
  // .byTypeExternalId('snippet-type-123')
  .toPromise();
// EndDocSection