// DocSection: cm_api_v2_post_snippet
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentTypeSnippet()
   .withData(builder => {
       return {
          name: "metadata",
          codename: "my_metadata",
          external_id: "snippet-item-123",
          elements: [
             builder.textElement({
               name: "Meta title",
               codename: "my_metadata__meta_title",
               guidelines: "Length: 30–60 characters",
               type: ElementModels.ElementType.text,
               external_id: "meta_title"
             }),
             builder.textElement({
               name: "Meta description",
               codename: "my_metadata__meta_description",
               guidelines: "Length: 70-150 characters",
               type: ElementModels.ElementType.text,
               external_id: "meta_title"
             })
          ]
       };
   })

  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection