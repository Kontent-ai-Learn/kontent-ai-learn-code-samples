// DocSection: import_rich_create_button_type
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient, ElementModels } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addContentType()
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
  .toPromise();
// EndDocSection