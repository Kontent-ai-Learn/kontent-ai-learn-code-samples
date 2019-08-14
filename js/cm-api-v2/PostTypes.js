// DocSection: cm_api_v2_post_types
// Using ES6 syntax
import { ContentManagementClient, ElementModels } from 'kentico-cloud-content-management';

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentType()
  .withData(
    {
      name: "Hosted video",
      external_id: "Content-Type-123",
      elements: [
        {
          name: "Video ID",
          guidelines: "",
          type: ElementModels.ElementType.text,
        },
        {
          mode: ElementModels.ElementMode.single,
          options: [
            {
              name: "YouTube"
            },
            {
              name: "Vimeo"
            }
          ],
          name: "Video host",
          guidelines: "",
          type: ElementModels.ElementType.multipleChoice,
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