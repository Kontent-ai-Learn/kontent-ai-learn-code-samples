// DocSection: cm_api_v2_get_snippet
// Using ES6 syntax
import { ContentManagementClient } from '@kentico/kontent-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.viewContentTypeSnippet()
  .byTypeId('269202ad-1d9d-47fd-b3e8-bdb05b3e3cf0')
  // .byTypeCodename('hosted_video')
  // .byTypeExternalId('snippet-type-123')
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection