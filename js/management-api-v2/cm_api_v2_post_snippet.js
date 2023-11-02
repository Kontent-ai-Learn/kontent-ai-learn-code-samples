// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: '<YOUR_ENVIRONMENT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.addContentTypeSnippet()
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

  .toPromise();
