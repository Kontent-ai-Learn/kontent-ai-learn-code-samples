// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = client.addContentTypeSnippet()
  .withData(builder => {
    return {
      name: 'Metadata',
      codename: 'metadata',
      elements: [
        builder.textElement({
          name: 'Title',
          codename: 'title',
          type: 'text'
        }),
        builder.textElement({
          name: 'Keywords',
          codename: 'keywords',
          type: 'text'
        }),
        builder.textElement({
          name: 'Description',
          codename: 'description',
          type: 'text'
        })
      ]
    };
  })
  .toPromise();
