// DocSection: import_model_create_snippet
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = client.addContentTypeSnippet()
  .withData(builder => {
    return {
      name: "Metadata",
      codename: "metadata",
      elements: [
        builder.textElement({
          name: "Title",
          codename: "title",
          type: 'text'
        }),
        builder.textElement({
          name: "Keywords",
          codename: "keywords",
          type: 'text'
        }),
        builder.textElement({
          name: "Description",
          codename: "description",
          type: 'text'
        })
      ]
    };
  })
  .toPromise();
// EndDocSection
