// DocSection: cm_api_v2_post_snippet
// Using ES6 syntax
import { ContentManagementClient } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentTypeSnippet()
  .withData(
    {
      name: "metadata",
      external_id: "snippet-item-123",
      elements: [
        {
          name: "Meta title",
          guidelines: "Length: 30–60 characters",
          type: ElementModels.ElementType.text,
          external_id: "meta_title"
        },
        {
          name: "Meta description",
          guidelines: "Length: 70-150 characters",
          type: ElementModels.ElementType.text,
          external_id: "meta_title"
        }
      ]
    }
  )
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection