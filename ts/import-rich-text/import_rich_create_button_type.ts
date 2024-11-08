// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient, ElementModels } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
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
