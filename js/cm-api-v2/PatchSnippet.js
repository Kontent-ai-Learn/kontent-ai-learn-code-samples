// DocSection: cm_api_v2_patch_snippet
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.modifyContentTypeSnippet()
  .byTypeId('269202ad-1d9d-47\fd-b3e8-bdb05b3e3cf0')
  //.byTypeCodename('hosted_video')
  //.byTypeExternalId('snippet-type-123')
  .withData(
    [
      {
        op: "replace",
        path: "/name",
        value: "A new snippet name"
      },
      {
        op: "replace",
        path: "/elements/codename:my_metadata__my_meta_description/guidelines",
        value: "Length: 70-150 characters."
      },
      {
        op: "addInto",
        path: "/elements",
        value: {
          name: "My meta title",
          type: "text",
          guidelines: "Length: 30–60 characters.",
          external_id: "my-meta-title-id"
        }
      },
      {
        op: "remove",
        path: "/elements/id:0b2015d0-16ae-414a-85f9-7e1a4b3a3eae"
      },
      {
        op: "remove",
        path: "/elements/external_id:my_multiple_choice/options/codename:my_option"
      }
    ]
  )
  .toObservable()
  .subscribe((response) => {
    // work with response
  },
  (error) => {
    // handle error
  });
// EndDocSection
