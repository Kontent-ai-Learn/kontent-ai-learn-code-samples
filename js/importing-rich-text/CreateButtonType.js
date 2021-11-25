// DocSection: import_rich_create_button_type
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient, ElementModels } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.addContentType()
  .withData(
    {
      external_id: "button",
      name: "Button",
      elements: [
        {
          name: "Text",
          type: ElementModels.ElementType.Text,
          externalId: "button-text"
        },
        {
          name: "Link",
          type: ElementModels.ElementType.Text,
          external_id: "button-link"
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