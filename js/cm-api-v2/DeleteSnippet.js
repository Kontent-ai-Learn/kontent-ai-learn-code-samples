// DocSection: cm_api_v2_delete_snippet
// Using ES6 syntax
import { ContentManagementClient } from '@kentico/kontent-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.deleteContentTypeSnippet()
  .byTypeId('baf884be-531f-441f-ae88-64205efdd0f6')
  // .byTypeCodename('metadata')
  // .byTypeExternalId('snippet-type-123')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection