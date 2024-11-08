// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('new-cafes')
  .byLanguageCodename('en-US')
  .withData((builder) => {
    return {
      elements: [
        builder.richTextElement({
          element: {
            codename: 'body_copy'
          },
          value: '<p>...</p> <figure data-asset-external-id=\"brno-cafe-image\"></figure>',
          components: []
        })
      ]
    };
  })
  .toPromise();