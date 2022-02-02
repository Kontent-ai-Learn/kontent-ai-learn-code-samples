// DocSection: import_rich_create_simple_type
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient, ElementModels } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addContentType()
  .withData(
    {
      external_id: "simple-rich-text",
      name: "Simple Rich Text",
      elements: [
        {
          name: "Rich Text",
          type: ElementModels.ElementType.RichText,
          external_id: "rich-text"
        }
      ]
    }
  )
  .toPromise();
// EndDocSection