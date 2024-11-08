// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
  environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
  apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client.upsertLanguageVariant()
  .byItemExternalId('123')
  .byLanguageCodename('en-US')
  .withData((builder) => {
    return {
      elements: [
        builder.textElement({
          element: {
            codename: 'title'
          },
          value: 'On Roasts'
        }),
        builder.linkedItemsElement({
          element: {
            codename: 'related_articles'
          },
          value: [
            {
              external_id: '456'
            }
          ]
        })
      ]
    }
  })
  .toPromise();
